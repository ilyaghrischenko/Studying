#pragma warning(disable:4996)
#include <iostream>
#include <ctime>
#include <cstring>
using namespace std;

int** NewArr(int size, int k_el)
{
	int** arr = new int* [size];
	for (int i = 0; i < size; ++i) {
		arr[i] = new int[k_el];
		for (int j = 0; j < k_el; ++j) {
			arr[i][j] = rand() % 10 - 3;
		}
	}

	//task 1
	/*arr[rand() % size][rand()%k_el] = 0;
	arr[rand() % size][rand()%k_el] = 0;*/

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

void PrintArr(char** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << endl;
	}
	cout << endl;
}

void DelArr(int** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
}

void DelArr(char** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
}

//task 1
/*
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
	for (; i < size; ++i) {
		for (j = 0; j < k_el; ++j) {
			if (arr[i][j] == 0) {
				break;
			}
		}
		if (j == k_el) {
			new_arr[k] = arr[i];
			++k;
		}
		else delete[] arr[i];
	}
	
	delete[] arr;
	arr = new_arr;
	size -= kilkist;
}
*/

//task 2
/*
int** SumTwoArr(int** arr1, int** arr2, int size, int k_el)
{
	int** new_arr = new int*[size];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = new int[k_el] {0};
		
	}

	for (int i = 0; i < size; ++i) {
		for (int j = 0; j < k_el; ++j) {
			new_arr[i][j] = arr1[i][j] + arr2[i][j];
		}
	}

	return new_arr;
}
*/

//task 3
/*
int** MultiplArrays(int** arr1, int size, int k_el, int** arr2,  int k_el2)
{
	int** new_arr = new int*[size];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = new int[k_el2] {0};
	}

	for (int i = 0; i < size; ++i) {
		for (int j = 0; j < k_el2; ++j) {
			for (int k = 0; k < k_el; ++k) {
				new_arr[i][j] += arr1[i][k] * arr2[k][j];
			}
		}
	}

	return new_arr;
}
*/

//task 4
void SortSurname(char**& arr, int size)
{
	char* pI = new char[80];
	char* pJ = new char[80];
	for (int i = 0; i < size-1; ++i) {

		for (int j = i + 1; j < size; ++j) {
			strcpy(pI, arr[i]);
			pI = strtok(pI, " ");
			strcpy(pJ, arr[j]);
			pJ = strtok(pJ, " ");
			if (strlen(pI) > strlen(pJ)) {
				swap(arr[i], arr[j]);
				
			}
		}
	}
	delete[] pI;
	delete[] pJ;
}

int main()
{
	srand((unsigned)time(NULL));
	setlocale(0, "");

	//task 1,2,3
	/*
	int size, k_el;
	cout << "Введіть розмір та к-сть елементів по черзі:\n";
	cin >> size >> k_el;

	cout << "\n1 mas:\n";
	int** arr = NewArr(size, k_el);
	for (int i = 0; i < size; ++i) {
		PrintArr(arr[i], k_el);
	}
	*/

	//task 1
	/*
	Del0(arr, size, k_el);
	cout << endl;
	for (int i = 0; i < size; ++i) {
		PrintArr(arr[i], k_el);
	}

	for (int i = 0; i < size; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
	*/
	
	//task 2
	/*
	cout << "\n2 mas:\n";
	int** arr2 = NewArr(size, k_el);
	for (int i = 0; i < size; ++i) {
		PrintArr(arr2[i], k_el);
	}

	cout << "\nSum mas:\n";
	int** new_arr = SumTwoArr(arr, arr2, size, k_el);
	for (int i = 0; i < size; ++i) {
		PrintArr(new_arr[i], k_el);
	}

	for (int i = 0; i < size; ++i) {
		delete[] arr[i], arr2[i], new_arr[i];
	}
	delete[] arr, arr2, new_arr;
	*/

	//task 3
	/*
	int size2 = k_el, k_el2 = size;

	cout << "\n2 mas:\n";
	int** arr2 = NewArr(size2, k_el2);
	for (int i = 0; i < size2; ++i) {
		PrintArr(arr2[i], k_el2);
	}

	cout << "\n3 mas:\n";
	int** new_arr = MultiplArrays(arr, size, k_el, arr2, k_el2);
	for (int i = 0; i < size; ++i) {
		PrintArr(new_arr[i], k_el2);
	}

	DelArr(arr, size);
	DelArr(arr2, size2);
	DelArr(new_arr, size);
	*/

	//task 4
	int size;
	cout << "Введіть к-сть студентів: ";
	cin >> size;
	cin.ignore();

	char** arr = new char*[size];
	for (int i = 0; i < size; ++i) {
		arr[i] = new char[80];
		cout << "Введіть ПІП: ";
		cin.getline(arr[i], 80);
	}

	cout << "\nПочатковий масив:\n";
	PrintArr(arr, size);
	//cout << endl << strtok(arr[0], " ") << endl;

	SortSurname(arr, size);

	cout << "\nВідсортований масив:\n";
	PrintArr(arr, size);

	DelArr(arr, size);

	cout << endl;
	system("pause");
}