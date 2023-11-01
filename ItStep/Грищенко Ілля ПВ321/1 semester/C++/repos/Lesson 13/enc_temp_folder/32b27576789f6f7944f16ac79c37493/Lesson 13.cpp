#include <iostream>
#include <ctime>
using namespace std;

int** NewArr(int size, int k_el)
{
	int** arr = new int* [size];
	for (int i = 0; i < size; ++i) {
		arr[i] = new int[k_el];
		for (int j = 0; j < k_el; ++j) {
			arr[i][j] = rand() % 10 + 10;
		}
	}

	arr[rand() % size][rand()%k_el] = 0;
	arr[rand() % size][rand()%k_el] = 0;

	return arr;
}

void PrintArr(int* arr, int k_el)
{
	for (int i = 0; i < k_el; ++i) {
		cout.width(4);
		cout << arr[i];
	}
	cout << endl;
}

void Del0(int**& arr, int& size, int k_el)
{
	int kilkist = 0;
	for (int i = 0; i < size; ++i) {
		for (int j = 0; j < k_el; ++j) {
			if (arr[i][j] == 0) {
				++kilkist;
				break;
			}
		}
	}

	int** new_arr = new int* [size - kilkist];

	int i = 0, j = 0, k = 0;
	for (i, k; i < size; ++i) {
		for (j = 0; j < k_el; ++j) {
			if (arr[i][j] == 0) {
				break;
			}
		}
		if (arr[i][j] != 0) {
			new_arr[k] = arr[i];
			++k;
		}
	}
	
	delete[] arr;
	arr = new_arr;
}

int main()
{
	srand((unsigned)time(NULL));
	setlocale(0, "");

	int size, k_el;
	cout << "Введіть розмір та к-сть елементів по черзі:\n";
	cin >> size >> k_el;

	int** arr = NewArr(size, k_el);
	for (int i = 0; i < size; ++i) {
		PrintArr(arr[i], size);
	}

	Del0(arr, size, k_el);
	cout << endl;
	for (int i = 0; i < size; ++i) {
		PrintArr(arr[i], size);
	}

	cout << endl;
	system("pause");
}