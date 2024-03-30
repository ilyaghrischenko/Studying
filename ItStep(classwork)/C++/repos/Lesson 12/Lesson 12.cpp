#include <iostream>
#include <ctime>
using namespace std;

void show(int* arr, int k_el)
{
	for (int i = 0; i < k_el; ++i) {
		cout.width(4);
		cout << arr[i];
	}
	cout << endl;
}

void show(char** arr, int rows)
{
	for (int i = 0; i < rows; ++i) {
		cout << arr[i] << endl;
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

void DelArr(char** arr, int rows)
{
	for (int i = 0; i < rows; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
}

//task 1
/*
int** AddNewRow(int** arr, int rows, int k_el)
{
	int** new_arr = new int* [rows + 1]{ 0 };
	if (new_arr) {
		for (int i = 0; i < rows; ++i) {
			new_arr[i] = arr[i];
		}


		//delete[] arr;

		new_arr[rows] = new int[k_el];
		if (!new_arr[rows]) return NULL;
		for (int i = 0; i < k_el; ++i) {
			new_arr[rows][i] = rand() % 10 - 3;
		}
	}
	return new_arr;
}
*/

//task 2
/*
int** AddFirstRow(int** arr, int rows, int k_el)
{
	int** new_arr = new int* [rows + 1];
	for (int i = 0; i < rows; ++i) {
		new_arr[i + 1] = arr[i];
	}
	delete[] arr;

	new_arr[0] = new int[k_el];
	for (int i = 0; i < k_el; ++i) {
		new_arr[0][i] = rand() % 10 - 3;
	}

	return new_arr;
}
*/

//task 3
/*
int** InsertArr(int** arr, int& rows, int k_el, int position)
{
	//++rows;
	int** new_arr = new int* [++rows];
	for (int i = 0, k = 0; i < rows; ++i) {
		if (i == position - 1) {
			new_arr[i] = new int[k_el];
			for (int j = 0; j < k_el; ++j) {
				new_arr[i][j] = rand() % 10 - 3;
			}
		}
		else {
			new_arr[i] = arr[k];
			++k;
		}
	}
	delete[] arr;

	return new_arr;
}
*/

//task 4
/*
void DelPosition(int**& arr, int& rows, int position)
{
	int** new_arr = new int* [rows-1];
	for (int i = 0, k = 0; i < rows; ++i) {
		if (i == position - 1) continue;
		new_arr[k] = arr[i];
		++k;
		
	}
	--rows;
	delete[] arr[position - 1];
	delete[] arr;

	arr = new_arr;
}
*/

//task 5
/*
char* MaxLastName(char** arr, int rows)
{
	char* maxLen = arr[0];
	for (int i = 0; i < rows; ++i) {
		if (strlen(arr[i]) > strlen(maxLen)) maxLen = arr[i];
	}

	return maxLen;
}
*/

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	/*
	type* namePtr = new type[size];
	type=typeElRow*

	typeElRow**=new typeElRow*[size];
	for(auto i=0;i<size;++i) {
		namePtr[i]=new typeElRow[sizeCol];
	}


	for(auto i=0;i<size;++i) {
		delete[] namePtr[i];
	}
	delete[] namePtr;


	int nR, mC;
	cout << "Введіть к-сть рядків і к-сть елементів в кожному рядку:\n";
	cin >> nR >> mC;
	int** namePtr = new int*[nR];
	if (!namePtr) {
		cerr << "Error: memory!";
		system("pause");
		return 1;
	}
	for (auto i = 0; i < nR; ++i) {
		namePtr[i] = new int[mC];
		for (auto j = 0; j < mC; ++j) {
			namePtr[i][j] = rand() % 10 - 3;
		}
	}

	cout << "\n Array:\n";
	for (auto i = 0; i < nR; ++i) {
		show(namePtr[i], mC);
	}

	//swap(namePtr[0], namePtr[nR - 1]);
	int* buf;
	buf = namePtr[0];
	namePtr[0] = namePtr[nR - 1];
	namePtr[nR - 1] = buf;

	cout << "\n Array:\n";
	for (auto i = 0; i < nR; ++i) {
		show(namePtr[i], mC);
	}

	for (auto i = 0; i < nR; ++i) {
		delete[] namePtr[i];
	}
	delete[] namePtr;

	int nR, mC;
	cout << "Введіть к-сть рядків і к-сть елементів в кожному рядку:\n";
	cin >> nR >> mC;
	int*** a = new int** [nR];
	for (auto i = 0; i < nR; ++i) {
		a[i] = new int*[mC];
		for (auto j = 0; j < mC; ++j) {
			a[i][j] = new int[mC];
			for (auto k = 0; k < mC; ++k) {
				a[i][j][k] = rand() % 10 - 3;
			}
		}
	}
	*/

	int rows, k_el;
	cout << "Введіть к-сть рядків: ";
	cin >> rows;
	cin.ignore();

	/*int** arr = new int* [rows] {0};
	for (int i = 0; i < rows; ++i) {
		arr[i] = new int[k_el];
		for (int j = 0; j < k_el; ++j) {
			arr[i][j] = rand() % 10 - 3;
		}
	}

	for (int i = 0; i < rows; ++i) {
		show(arr[i], k_el);
	}
	cout << endl;*/

	//task 1
	/*
	cout << "\n\n";

	int** new_arr = AddNewRow(arr, rows, k_el);
	if (new_arr != NULL) {
		++rows;
		delete[] arr;
		arr = new_arr;
	}
	for (int i = 0; i < rows; ++i) {
		show(arr[i], k_el);
	}

	for (int i = 0; i < rows; ++i) {
		delete[] arr[i];
	}
	delete[] arr;

	cout << endl;
	system("pause");
	*/

	//task 2
	/*
	arr = AddFirstRow(arr, rows, k_el);

	//arr = new_arr;
	++rows;
	for (int i = 0; i < rows; ++i) {
		show(arr[i], k_el);
	}
	*/

	//task 3
	/*
	int position;
	cout << "Введіть позицію: ";
	cin >> position;
	if (position<0 || position>rows) {
		cerr << "Error\n";
		system("pause");
		return 1;
	}

	int** new_arr = InsertArr(arr, rows, k_el, position);
	arr = new_arr;

	for (int i = 0; i < rows; ++i) {
		show(arr[i], k_el);
	}

	for (int i = 0; i < rows; ++i) {
		delete[] arr[i];
	}
	delete[] arr;
	*/

	//task 4
	/*
	int position;
	cout << "Введіть позицію: ";
	cin >> position;
	
	if (position < 1 || position > rows) {
		cerr << "Error\n";
		system("pause");
		DelArr(arr, rows);
		return 1;
	}

	DelPosition(arr, rows, position);

	for (int i = 0; i < rows; ++i) {
		show(arr[i], k_el);
	}
	DelArr(arr, rows);
	*/
	
	//task 5
	/*
	int size = 50;
	char** arr = new char* [rows] {0};
	for (int i = 0; i < rows; ++i) {
		arr[i] = new char[size];
		cout << "Введіть прізвище: ";
		cin.getline(arr[i], size);
	}

	cout << "\nМасив:\n";
	show(arr, rows);

	char* maxLen = MaxLastName(arr, rows);
	cout << "\nМаксимальне прізвище: " << maxLen << endl;

	DelArr(arr, rows);
	*/

	system("pause");
	cout << endl;
}