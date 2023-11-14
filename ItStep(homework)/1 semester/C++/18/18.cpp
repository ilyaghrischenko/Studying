#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
#include <fstream>
#define N 512
using namespace std;

class Reservoir {
private:
	char name[N];
	char type[N];
	double width;
	double lenght;
	double max_depth;
public:
	Reservoir()
	{
		strcpy(name, "No name");
		strcpy(type, "No type");
		width = 0;
		lenght = 0;
		max_depth = 0;
	}
	Reservoir(const char* name, const char* type) :Reservoir()
	{
		strcpy(this->name, name);
		strcpy(this->type, type);
	}
	Reservoir(double width, double lenght, double max_depth) :Reservoir()
	{
		this->width = width;
		this->lenght = lenght;
		this->max_depth = max_depth;
	}
	explicit Reservoir(const char* name,const char* type, double width, double lenght, double max_depth) :width(width), lenght(lenght), max_depth(max_depth)
	{
		strcpy(this->name, name);
		strcpy(this->type, type);
	}

	inline const char* GetName() const {
		return name;
	}
	inline void SetName(const char* name)
	{
		strcpy(this->name, name);
	}

	inline const char* GetType() const
	{
		return type;
	}
	inline void SetType(const char* type)
	{
		strcpy(this->type, type);
	}

	inline double GetWidth() const
	{
		return width;
	}
	inline void SetWidth(double width)
	{
		this->width = width;
	}

	inline double GetLenght() const
	{
		return lenght;
	}
	inline void SetLenght(double lenght)
	{
		this->lenght = lenght;
	}

	inline double GetMaxDepth() const
	{
		return max_depth;
	}
	inline void SetMaxDepth(double max_depth)
	{
		this->max_depth = max_depth;
	}

	inline void input()
	{
		cout << "Ім'я: ";
		cin.getline(name, N);

		cout << "Тип: ";
		cin.getline(type, N);

		cout << "Ширина: ";
		cin >> width;

		cout << "Довжина: ";
		cin >> lenght;

		cout << "Макс. глибина: ";
		cin >> max_depth;

		cin.ignore();
	}
	inline void show() const
	{
		cout << "Ім'я: " << name << " | Тип: " << type << " | Ширина: " << width << " | Довжина: " << lenght << " | Макс. глубина: " << max_depth << endl << endl;
	}

	//1
	inline double CalcVolume() const
	{
		return width * lenght * max_depth;
	}
	//2
	inline double CalcSquare() const
	{
		return width * lenght;
	}
};	

//3
bool CheckType(const Reservoir& x, const Reservoir& y)
{
	return (strcmp(x.GetType(), y.GetType()) == 0) ? true : false;
}

//4
bool CheckSquare(const Reservoir& x, const Reservoir& y)
{
	return (CheckType(x, y) && x.CalcSquare() > y.CalcSquare()) ? true : false;
}

//6
void PutInTxt(const Reservoir& object, const char* path)
{
	fstream file(path, ios::app);

	file << "Назва: " << object.GetName() << " | ";
	file << "Тип: " << object.GetType() << " | ";
	file << "Ширина: " << object.GetWidth() << " | ";
	file << "Довжина: " << object.GetLenght() << " | ";
	file << "Макс. глибина: " << object.GetMaxDepth() << endl;
}
void PutInTxt(const Reservoir**& arr, int size, const char* path)
{
	fstream file(path, ios::app);

	file << "Масив об'єктів:\n";
	for (int i = 0; i < size; ++i) {
		file << "Назва: " << arr[i]->GetName() << " | ";
		file << "Тип: " << arr[i]->GetType() << " | ";
		file << "Ширина: " << arr[i]->GetWidth() << " | ";
		file << "Довжина: " << arr[i]->GetLenght() << " | ";
		file << "Макс. глибина: " << arr[i]->GetMaxDepth() << endl;
	}
}

Reservoir** NewArr(int size)
{
	Reservoir** arr = new Reservoir* [size];
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << ") об'єкт класу:\n";
		arr[i] = new Reservoir;
		arr[i]->input();
		cout << endl;
	}

	return arr;
}
void PrintArr(Reservoir** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << ".\n";
		arr[i]->show();
	}
}
void DelArr(Reservoir**& arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete arr[i];
	}

	delete[] arr;
}
void AddToArr(Reservoir**& arr, int& size)
{
	size += 1;
	cout << size << ") об'єкт класу:\n";
	arr[size - 1] = new Reservoir;
	arr[size - 1]->input();
}
void DelObj(Reservoir**& arr, int& size)
{
	delete arr[size - 1];
	size -= 1;
}

int main()
{
	setlocale(0, "");

	int size = 0;
	cout << "Введіть розмір: ";
	cin >> size;
	cin.ignore();

	Reservoir a{ "name1","type1",20,10,50 };
	Reservoir b{ "name2","type2",20,10,43 };

	Reservoir** arr = NewArr(size);
	
	cout << "Масив:\n";
	PrintArr(arr, size);

	AddToArr(arr, size);
	PrintArr(arr, size);

	int n = -1;
	int number = 0;
	while (n != 0) {
		cout << "1 - Приблизний обсяг\n2 - Площа водної поверхні\n3 - Рівність типу\n4 - Рівність площ одного типу\n0 - Вихід\n\n: ";
		cin >> n;

		switch (n) {
		case 1:
			cout << "Введіть порядковий номер об'єкта(0 - " << size - 1 << "): ";
			cin >> number;

			cout << "Приблизний обсяг(" << number << " об'єкт): " << arr[number]->CalcVolume() << endl << endl;
			break;
		case 2:
			cout << "Введіть порядковий номер об'єкта(0 - " << size - 1 << "): ";
			cin >> number;

			cout << "Площа водної поверхні(" << number << " об'єкт): " << arr[number]->CalcSquare() << endl << endl;
			break;
		case 3:
			cout << "Рівність типу: " << CheckType(a, b) << endl << endl;
			break;
		case 4:
			cout << "Рівність площ одного типу: " << CheckSquare(a, b) << endl << endl;
			break;
		}
	}
	cout << "Програму завершено.\n";

	DelArr(arr, size);

	cout << endl;
	system("pause");
}