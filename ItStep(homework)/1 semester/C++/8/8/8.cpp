#include <iostream>
#include <ctime>
using namespace std;

typedef int* pointer;

void NewArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i, ++arr)
	{
		*arr = rand() % 10 - 5;
	}
	arr -= size;
}

void PrintArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i, ++arr) {
		cout << *arr << "  ";
	}
	arr -= size;
}

//task 2
/*
void PrintReverse(pointer arr, int size)
{
	arr += size - 1;
	for (int i = 0; i < size; ++i, --arr) {
		cout << *arr << "  ";
	}
}
*/

//task 3
/*
int CalcSize(pointer arr1, int m, pointer arr2, int n)
{
	int size = m;
	for (int i = 0; i < n; ++i, ++arr2) {
		bool isSame = false;
		for (int j = 0; j < m; ++j, ++arr1) {
			if (*arr2 == *arr1) {
				isSame = true;
				break;
			}
		}
		if (isSame = false) ++size;
	}
	arr2 -= n;
	arr1 -= m;

	return size;
}

void ArrNoPovt(pointer arr1, int m, pointer arr2, int n, pointer& arr3, int& size)
{
	int newSize = 0;

	for (int i = 0; i < m; ++i, ++arr1) {
		bool isUnique = true;
		for (int j = 0; j < newSize; ++j) {
			if (*arr1 == arr3[j]) {
				isUnique = false;
				break;
			}
		}
		if (isUnique) {
			arr3[newSize] = *arr1;
			++newSize;
		}
	}

	for (int i = 0; i < n; ++i, ++arr2) {
		bool isUnique = true;
		for (int j = 0; j < newSize; ++j) {
			if (*arr2 == arr3[j]) {
				isUnique = false;
				break;
			}
		}
		if (isUnique) {
			arr3[newSize] = *arr2;
			++newSize;
		}
	}

	size = newSize;
}
*/

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//task 1
	/*
	int size;
	cout << "Введіть розмір масивів: ";
	cin >> size;

	pointer arr1 = new int[size];
	pointer arr2 = new int[size];
	NewArr(arr1, size);
	NewArr(arr2, size);

	cout << "\nПочаткове значення 1 масива\n";
	PrintArr(arr1, size);
	cout << "\nПочаткове значення 2 масива\n";
	PrintArr(arr2, size);

	cout << endl;
	system("pause");

	for (int i = 0; i < size; ++i, ++arr1, ++arr2) {
		*arr2 = *arr1;
	}
	arr1 -= size;
	arr2 -= size;

	cout << "\n1 масив\n";
	PrintArr(arr1, size);
	cout << "\n2 масив\n";
	PrintArr(arr2, size);

	cout << endl;
	system("pause");

	delete[] arr1, arr2;
	*/

	//task 2
	/*
	int size;
	cout << "Введіть к-сть елементів масиву: ";
	cin >> size;

	pointer arr = new int[size];
	for (int i = 0; i < size; ++i, ++arr) {
		*arr = rand() % 10 + 1;
	}
	arr -= size;

	cout << "\nПочатковий вид масиву\n";
	PrintArr(arr, size);

	cout << endl;
	system("pause");

	cout << "\nОбернений масив\n";
	PrintReverse(arr, size);

	cout << endl;
	system("pause");

	delete[] arr;
	*/

	//task 3
	/*
	int m, n;
	cout << "Введіть m i n по черзі\n";
	cin >> m >> n;

	pointer A = new int[m] {0};
	pointer B = new int[n] {0};
	NewArr(A, m);
	NewArr(B, n);

	cout << "\nМасив А\n";
	PrintArr(A, m);

	cout << "\nМасив В\n";
	PrintArr(B, n);
	
	int size = CalcSize(A, m, B, n);
	pointer C = new int[size];
	ArrNoPovt(A, m, B, n, C, size);
	
	cout << "\nМасив С\n";
	PrintArr(C, size);

	delete[] A, B, C;
	*/
}