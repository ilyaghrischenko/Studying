#include <iostream>
#include <ctime>
using namespace std;

typedef int* pointer;

void NewArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 - 5;
	}
}

void PrintArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
}

//task 1
/*
//1
pointer MemoryRoz(int& size)
{
	pointer arr;
	return arr = new int[size];
}
//2
void NewArr(pointer& arr, int& size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 - 5;
	}
}
//3
void PrintArr(pointer& arr, int& size)
{
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
}
//4
void DelArr(pointer arr)
{
	delete[] arr;
}
//5
void AddEnd(pointer& arr, int& size, int number)
{
	pointer new_arr = new int[size + 1];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = arr[i];
	}

	new_arr[size] = number;

	size += 1;
	delete[] arr;
	arr = new_arr;
}
//6
void AddIndex(pointer& arr, int& size, int number, int index)
{
	pointer new_arr = new int[size + 1];
	for (int i = 0, j = 0; i < size + 1; ++i, ++j) {
		if (i == index) {
			new_arr[i] = number;
			--j;
		}
		else new_arr[i] = arr[j];
	}

	size += 1;
	delete[] arr;
	arr = new_arr;
}
//7
void DelIndex(pointer& arr, int& size, int index)
{
	pointer new_arr = new int[size - 1] {0};
	for (int i = 0, j = 0; i < size; ++i) {
		if (i == index) ++j;
		new_arr[i] = arr[j];
		++j;
	}

	size -= 1;
	delete[] arr;
	arr = new_arr;
}
*/

//task 2
/*
void DelPros(pointer& arr, int& size)
{
	int k_simple = 0;
	bool isSimple = false;
	for (int i = 0; i < size; ++i) {
		isSimple = true;
		if (arr[i] >= 2) {
			for (int j = 2; j * j <= arr[i]; ++j) {
				if (arr[i] % j == 0) {
					isSimple = false;
					break;
				}
			}
		}
		else isSimple = false;

		if (isSimple) ++k_simple;
		else arr[i - k_simple] = arr[i];
	}

	size -= k_simple;

	pointer new_arr = new int[size];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = arr[i];
	}

	delete[] arr;
	arr = new_arr;
}
*/

//task 3
/*
void Rozp(pointer arr, int size, int& k_d, int& k_v, int& k_0)
{
	for (int i = 0; i < size; ++i) {
		if (arr[i] > 0) ++k_d;
		else if (arr[i] < 0) ++k_v;
		else ++k_0;
	}
}

void ThreeArr(pointer arr, int size, pointer& arrD, pointer& arrV, pointer& arr0, int k_d, int k_v, int k_0)
{
	for (int i = 0, d = 0, v = 0, o = 0; i < size; ++i) {
		if (arr[i] > 0) {
			arrD[d] = arr[i];
			++d;
		}
		else if (arr[i] < 0) {
			arrV[v] = arr[i];
			++v;
		}
		else {
			arr0[o] = arr[i];
			++o;
		}
	}
}
*/

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//task 1
	/*
	int size = 5;
	pointer arr = MemoryRoz(size);
	NewArr(arr, size);
	PrintArr(arr, size);

	cout << endl;

	DelIndex(arr, size, 2);
	PrintArr(arr, size);

	cout << endl;
	system("pause");

	delete[] arr;
	*/

	//task 2
	/*
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;

	pointer arr = new int[size];
	NewArr(arr, size);

	cout << "\nМасив\n";
	PrintArr(arr, size);

	cout << endl;

	cout << "\nЗмінений масив\n";
	DelPros(arr, size);
	PrintArr(arr, size);

	cout << endl;
	system("pause");
	delete[] arr;
	*/

	//task 3
	/*
	const int size = 10;
	int arr[size];
	NewArr(arr, size);

	cout << "\nМасив\n";
	PrintArr(arr, size);

	int k_d = 0, k_v = 0, k_0 = 0;
	Rozp(arr, size, k_d, k_v, k_0);

	pointer arrD = new int[k_d];
	pointer arrV = new int[k_v];
	pointer arr0 = new int[k_0];
	ThreeArr(arr, size, arrD, arrV, arr0, k_d, k_v, k_0);

	cout << "\nМасив додатних\n";
	PrintArr(arrD, k_d);

	cout << "\nМасив від'ємних\n";
	PrintArr(arrV, k_v);

	cout << "\nМасив 0\n";
	PrintArr(arr0, k_0);

	cout << endl;
	system("pause");
	delete[] arrD, arrV, arr0;
	*/
}