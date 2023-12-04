#include <iostream>
#include <ctime>
using namespace std;

template<typename T>
class Matrix {
private:
	T** arr;
	int rows;
	int k_el;

	void Init(int rows, int k_el)
	{
		arr = new T * [this->rows = rows];
		for (int i = 0; i < rows; ++i) {
			arr[i] = new T[this->k_el = k_el]{ T() };
		}
	}
	void Del()
	{
		for (int i = 0; i < rows; ++i) {
			delete[] arr[i];
		}
		delete[] arr;
	}
public:
	Matrix() :arr(nullptr), rows(0), k_el(0) {}
	Matrix(T** arr, int rows, int k_el) :rows(rows), k_el(k_el)
	{
		this->arr = new T* [rows];
		for (int i = 0; i < rows; ++i) {
			this->arr[i] = new T[k_el];
			for (int j = 0; j < k_el; ++j) {
				this->arr[i][j] = arr[i][j];
			}
		}
	}
	~Matrix()
	{
		if (arr != nullptr) Del();
	}

	inline T** GetArr() const
	{
		return arr;
	}
	void SetArr(T** arr, int rows, int k_el)
	{
		if (this->arr != nullptr) Del();

		this->rows = rows;
		this->k_el = k_el;

		this->arr = new T* [rows];
		for (int i = 0; i < rows; ++i) {
			this->arr[i] = new T [k_el];
			for (int j = 0; j < k_el; ++j) {
				this->arr[i][j] = arr[i][j];
			}
		}
	}

	void random()
	{
		if (arr == nullptr) Init(3, 3);

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] = rand() % 10 + 1;
			}
		}
	}
	void input()
	{
		if (arr == nullptr) Init(3, 3);

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				cout << "Введiть " << i << " " << j << " елемент: ";
				cin >> arr[i][j];
			}
		}
	}
	void show(const string& name) const
	{
		if (arr == nullptr) {
			cout << "Матрицi не iснує!!\n";
			return;
		}

		cout << "Матриця " << name << ":\n";
		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				cout.width(4);
				cout << arr[i][j];
			}
			cout << endl;
		}
	}

	T GetMax() const
	{
		if (arr == nullptr) return T();

		T max = arr[0][0];
		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				if (arr[i][j] > max) max = arr[i][j];
			}
		}
	}
	T GetMin() const
	{
		if (arr == nullptr) return T();

		T min = arr[0][0];
		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				if (arr[i][j] < min) min = arr[i][j];
			}
		}
	}

	Matrix<T>& operator=(const Matrix<T>& x)
	{
		if (this == &x) return *this;
		if (arr != nullptr) Del();

		rows = x.rows;
		k_el = x.k_el;

		arr = new T * [rows];
		for (int i = 0; i < rows; ++i) {
			arr[i] = new T[k_el];
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] = x.arr[i][j];
			}
		}

		return *this;
	}
	Matrix<T> operator+(const Matrix<T>& x)
	{
		if (arr == nullptr) Init(3, 3);

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] += x.arr[i][j];
			}
		}

		return *this;
	}
	Matrix<T> operator-(const Matrix<T>& x)
	{
		if (arr == nullptr) Init(3, 3);

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] -= x.arr[i][j];
			}
		}

		return *this;
	}
	Matrix<T> operator*(const Matrix<T>& x)
	{
		if (arr == nullptr || x.arr == nullptr) return *this;
		if (k_el != x.rows) return *this;

		Matrix<T> result;
		result.rows = rows;
		result.k_el = x.k_el;
		Init(result.rows, result.k_el);

		result.arr = new T * [result.rows];
		for (int i = 0; i < result.rows; ++i) {
			result.arr[i] = new T[result.k_el]{ T() };
		}

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < x.k_el; ++j) {
				for (int k = 0; k < k_el; ++k) {
					result.arr[i][j] += arr[i][k] * x.arr[k][j];
				}
			}
		}

		return result;
	}
	Matrix<T> operator/(const Matrix<T>& x)
	{
		if (arr == nullptr || x.arr == nullptr) return *this;
		if (k_el != x.k_el) return;

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < x.rows; ++j) {
				for (int k = 0; k < k_el; ++k) {
					arr[i][j] += arr[i][k] * x.arr[j][k];
				}
			}
		}

		return *this;
	}
};

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	Matrix<int> a;
	Matrix<int> b;
	Matrix<int> c;

	a.random();
	b.random();
	c.random();
	//b.input();

	a.show("A");
	b.show("B");
	c.show("C");

	system("pause");

	a = c + b;
	a.show("New A");

	cout << endl;
	system("pause");
}