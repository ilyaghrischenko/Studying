#include <iostream>
#include <ctime>
using namespace std;

template<typename T>
class Matrix {
private:
	T** arr;
	int rows;
	int k_el;

	inline void Init()
	{
		arr = new T * [rows];
		for (int i = 0; i < rows; ++i) {
			arr[i] = new T[k_el]{ T() };
		}
	}
	inline void Del()
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
		if (this->arr != nullptr) Del();
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
		if (arr == nullptr) {
			rows = 2;
			k_el = 2;
			Init();
		}

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] = rand() % 10 + 1;
			}
		}
	}
	void input()
	{
		if (arr == nullptr) {
			rows = 2;
			k_el = 2;
			Init();
		}

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				cout << "Введiть " << i << " " << j << " елемент: ";
				cin >> arr[i][j];
			}
		}
	}
	void show() const
	{
		if (arr == nullptr) {
			cout << "Матрицi не iснує!!\n";
			return;
		}

		cout << "Матриця:\n";
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

	Matrix<T> operator=(const Matrix& x)
	{
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
	Matrix<T> operator+(const Matrix& x)
	{
		if (arr == nullptr) {
			rows = 2;
			k_el = 2;
			Init();
		}

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] += x.arr[i][j];
			}
		}

		return *this;
	}
	Matrix<T> operator-(const Matrix& x)
	{
		if (arr == nullptr) {
			rows = 2;
			k_el = 2;
			Init();
		}

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < k_el; ++j) {
				arr[i][j] -= x.arr[i][j];
			}
		}

		return *this;
	}
	Matrix<T> operator*(const Matrix& x)
	{
		if (arr == nullptr || x.arr == nullptr) return *this;
		if (k_el != x.rows) return *this;

		for (int i = 0; i < rows; ++i) {
			for (int j = 0; j < x.k_el; ++j) {
				for (int k = 0; k < k_el; ++k) {
					arr[i][j] += arr[i][k] * x.arr[k][j];
				}
			}
		}

		return *this;
	}
	Matrix<T> operator/(const Matrix& x)
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

	int rows = 3;
	int k_el = 4;

	int** arr1 = new int* [rows];
	for (int i = 0; i < 3; ++i) {
		arr1[i] = new int[k_el];
		for (int j = 0; j < k_el; ++j) {
			arr1[i][j] = rand() % 10 + 1;
		}
	}

	int** arr2 = new int* [rows];
	for (int i = 0; i < 3; ++i) {
		arr2[i] = new int[k_el];
		for (int j = 0; j < k_el; ++j) {
			arr2[i][j] = rand() % 10 + 1;
		}
	}

	Matrix<int> a(arr1, rows, k_el);
	Matrix<int> b(arr2, rows, k_el);

	a.show();
	cout << endl;
	b.show();

	a = a * b;
	a.show();

	cout << endl;
	system("pause");
}