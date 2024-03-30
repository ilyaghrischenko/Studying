#include <iostream>
#include <ctime>
using namespace std;

int** NewArr(int rows, int kilk_el)
{
	int** arr = new int*[rows];
	for (int i = 0; i < rows; ++i) {
		arr[i] = new int[kilk_el];
		for (int j = 0; j < kilk_el; ++j) {
			arr[i][j] = rand() % 10 - 3;
		}
	}

	return arr;
}

void PrintArr(string name, int** arr, int rows, int kilk_el)
{
	cout << "\n " << name << ":\n";
	for (int i = 0; i < rows; ++i) {
		for (int j = 0; j < kilk_el; ++j) {
			cout.width(4);
			cout << arr[i][j];
		}
		cout << endl;
	}
	cout << endl;
}

void DelArr(int** arr, int rows)
{
	for (int i = 0; i < rows; ++i) {
		delete[] arr[i];
	}

	delete[] arr;
}

//task 1
/*
void AddRow(int**& arr, int& rows, int kilk_el, int position)
{
	++rows;

	int** new_arr = NewArr(rows, kilk_el);
	for (int i = 0, k = 0; i < rows; ++i) {
		if (i == position - 1) {
			for (int j = 0; j < kilk_el; ++j) {
				new_arr[i][j] = rand() % 10 - 3;
			}
		}
		else {
			new_arr[i] = arr[k];
			++k;
		}
	}

	delete[] arr;
	arr = new_arr;
}
*/

//task 2
/*
void DelPos(int**& arr, int& rows, int kilk_el, int position)
{
	--rows;

	int** new_arr = NewArr(rows, kilk_el);
	for (int i = 0, k = 0; i < rows + 1; ++i) {
		if (i == position - 1) continue;
		else {
			new_arr[k] = arr[i];
			++k;
		}
	}

	delete[] arr;
	arr = new_arr;
}
*/

//task 3
/*
int* MinRow(int** arr, int rows, int kilk_el)
{
	int* min_arr = new int[rows];
	for (int i = 0; i < rows; ++i) {
		int min = arr[i][0];
		for (int j = 1; j < kilk_el; ++j) {
			if (arr[i][j] < min) min = arr[i][j];
		}
		min_arr[i] = min;
	}

	return min_arr;
}
*/

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	int rows, kilk_el;
	cout << "Введіть к-ть рядків та к-ть елементів:\n";
	cin >> rows >> kilk_el;

	int** arr = NewArr(rows, kilk_el);
	PrintArr("Масив", arr, rows, kilk_el);

	//task 1
	/*
	AddRow(arr, rows, kilk_el, 1);
	PrintArr("Оновлений масив", arr, rows, kilk_el);

	DelArr(arr, rows);
	*/

	//task 2
	/*
	DelPos(arr, rows, kilk_el, 1);
	PrintArr("Оновлений масив", arr, rows, kilk_el);

	DelArr(arr, rows);
	*/

	//task 3
	/*
	int* min_arr = MinRow(arr, rows, kilk_el);
	
	cout << "Масив мінімальних елементів з кожного рядка:\n";
	for (int i = 0; i < rows; ++i) {
		cout << i << " рядок: " << min_arr[i] << endl;
	}

	DelArr(arr, rows);
	delete[] min_arr;
	*/

	cout << endl;
	system("pause");
}