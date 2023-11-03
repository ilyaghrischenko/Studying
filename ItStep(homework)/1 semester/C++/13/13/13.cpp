#pragma warning (disable:4996)
#include <iostream>
#include <cstring>
#include <ctime>
using namespace std;

//char 2d
char** NewArr(int size)
{
	char** arr = new char* [size];
	for (int i = 0; i < size; ++i) {
		arr[i] = new char[80];
		cout << i + 1 << " прізвище: ";
		cin.getline(arr[i], 80);
	}

	return arr;
}

void PrintArr(string name, char** arr, int size)
{
	cout << endl << name << ":\n";
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << endl;
	}
	cout << endl;
}

void DelArr(char**& arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
}

//char 3d
char*** New3Arr(int size, int kilk = 2)
{
	char*** arr = new char** [size];
	cin.ignore();
	for (int i = 0; i < size; ++i) {
		arr[i] = new char* [kilk];
		cout << "\nІм'я, потім номер:\n";
		for (int j = 0; j < kilk; ++j) {
			arr[i][j] = new char[80];
			cin.getline(arr[i][j], 80);
		}
	}

	return arr;
}

void Print3Arr(string name, char*** arr, int size, int kilk = 2)
{
	cout << endl << name << ":\n";
	for (int i = 0; i < size; ++i) {
		for (int j = 0; j < kilk; ++j) {
			cout << arr[i][j] << "  ";
		}
		cout << endl;
	}
}

void Del3Arr(char***& arr, int size, int kilk = 2)
{
	for (int i = 0; i < size; ++i) {
		for (int j = 0; j < kilk; ++j) {
			delete[] arr[i][j];
		}
		delete[] arr[i];
	}
	delete[] arr;
}

//int
int** NewArr(int rows, int kilk)
{
	int** arr = new int* [rows];
	for (int i = 0; i < rows; ++i) {
		arr[i] = new int[kilk];
		for (int j = 0; j < kilk; ++j) {
			arr[i][j] = rand() % 10 - 3;
		}
	}

	return arr;
}

void PrintArr(string name, int** arr, int rows, int kilk)
{
	cout << endl << name << ":\n";
	for (int i = 0; i < rows; ++i) {
		for (int j = 0; j < kilk; ++j) {
			cout.width(4);
			cout << arr[i][j];
		}
		cout << endl;
	}
	cout << endl;
}

void DelArr(int**& arr, int rows)
{
	for (int i = 0; i < rows; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
}

//task 1
/*
void SortMas(char**& arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if ((int)arr[i][0] > (int)arr[j][0]) swap(arr[i], arr[j]);
		}
	}
}
*/

//task 2
/*
void TransportArr(int**& arr, int& rows, int& kilk)
{
	swap(rows, kilk);

	int** new_arr = NewArr(rows, kilk);
	for (int i = 0; i < rows; ++i) {
		for (int j = 0; j < kilk; ++j) {
			new_arr[i][j] = arr[j][i];
		}
	}

	delete[] arr;
	arr = new_arr;
}
*/

//task 3
void AddRow(char***& arr, int& size) {
	char*** newArr = new char** [size + 1];
	for (int i = 0; i < size; ++i) {
		newArr[i] = new char* [2];
		for (int j = 0; j < 2; ++j) {
			newArr[i][j] = new char[80];
			strcpy(newArr[i][j], arr[i][j]);
			delete[] arr[i][j];
		}
		delete[] arr[i];
	}

	newArr[size] = new char* [2];
	cin.ignore();
	cout << "\nІм'я, потім номер:\n";
	for (int i = 0; i < 2; ++i) {
		newArr[size][i] = new char[80];
		cin.getline(newArr[size][i], 80);
	}

	delete[] arr;

	++size;

	arr = newArr;
}


void Change(char*** arr, int size, char* searching, char* replace, int n) {
	for (int i = 0; i < size; ++i) {
		if (strcmp(arr[i][n - 1], searching) == 0) {
			strcpy(arr[i][n - 1], replace);
		}
	}
}


int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//task 1
	/*
	int size;
	cout << "Введіть к-сть студентів: ";
	cin >> size;
	cin.ignore();

	char** arr = NewArr(size);
	PrintArr("Масив прізвищ", arr, size);

	SortMas(arr, size);
	PrintArr("Відсортований масив", arr, size);

	DelArr(arr, size);
	*/

	//task 2
	/*
	int rows, kilk;
	cout << "К-сть рядків та елементів:\n";
	cin >> rows >> kilk;

	int** arr = NewArr(rows, kilk);
	PrintArr("Масив", arr, rows, kilk);

	TransportArr(arr, rows, kilk);
	PrintArr("Змінений масив", arr, rows, kilk);

	DelArr(arr, rows);
	*/

	//task 3
	int size, kilk = 2;
	cout << "Введіть к-сть рядків: ";
	cin >> size;

	char*** arr = New3Arr(size);
	Print3Arr("3-х вимірний масив", arr, size);

	int action;
	cout << "\n1 - Змінити дані\n2 - Додати нову людину\n";
	cin >> action;

	if (action != 1 && action != 2) {
		cerr << "Помилка! Не правильний ввід.\n";
		system("pause");
		return 1;
	}
	
	char* searching = new char[80];
	char* replace = new char[80];
	switch (action) {
	case 1:
		int n;
		cout << "\n1 - змінити ім'я\n2 - змінити номер\n";
		cin >> n;

		if (n != 1 && n != 2) {
			cerr << "Помилка! Не правильний ввід.\n";
			system("pause");
			return 1;
		}
		
		cin.ignore();
		
		if (n == 1) {
			cout << "Введіть ім'я, яке треба змінити: ";
			cin.getline(searching, 80);

			cout << "Введіть заміну: ";
			cin.getline(replace, 80);
		}

		else if (n == 2) {
			cout << "Введіть номер, який треба змінити: ";
			cin.getline(searching, 80);

			cout << "Введіть заміну: ";
			cin.getline(replace, 80);
		}

		else {
			cerr << "Помилка! Не правильний ввід.\n";
			system("pause");
			return 1;
		}

		Change(arr, size, searching, replace, n);

		break;
	case 2:
		AddRow(arr, size);

		break;
	default:
		cerr << "Помилка! Не правильний ввід.\n";
		system("pause");
		return 1;

		break;
	}

	Print3Arr("Оновлений масив", arr, size);

	Del3Arr(arr, size);
	delete[] replace, searching;

	cout << endl;
	system("pause");
}