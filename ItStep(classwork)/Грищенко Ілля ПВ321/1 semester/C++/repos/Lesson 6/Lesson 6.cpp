#include <iostream>
#include <ctime>
#define n 10
using namespace std;

//task 1
/*
void square()
{
	int n, k;
	cout << "Введіть висоту та ширину по черзі:\n";
	cin >> n >> k;

	cout << endl;

	for (int i = 0; i < n; i++) {
		if (i == 0 || i == n - 1) {
			for (int j = 0; j < k; j++) {
				cout << "*";
			}
			cout << endl;
		}
		else {
			cout << "* ";
			for (int x = 0; x < k - 3; x++) {
				cout << " ";
			}
			cout << "*";
			cout << endl;
		}
	}
}
*/

//task 2
/*
void proste(int x)
{
	int d = 0;
	for (int i = 2; i <= x; i++) {
		if (x % i == 0) d++;
	}

	if (d > 1) cout << "Число не просте" << endl;
	else cout << "Число просте" << endl;
}
*/

//task 3
/*
void func(int x)
{
	for (int i = 1; i <= x - (x % 7); i++) {
		cout << i << ' ';
		if (i % 7 == 0) cout << endl;
	}
	for (int i = 1 + (x - (x % 7)); i <= x; i++) {
		cout << i + 5 << " ";
	}
	cout << endl;
}
*/

//task 4
/*
void mas(int arr[],int size,int mm[])
{
	int min = arr[0], max = arr[0];
	for (int i = 0; i < size; i++) {
		if (arr[i] > max) max = arr[i];
		if (arr[i] < min) min = arr[i];
	}
	mm[0] = min;
	mm[1] = max;
	//cout << "\nMin = " << min << "\nMax = " << max;
}
void mas(int arr[], int size, int& min,int& max)
{
	min = arr[0];
	max = arr[0];
	for (int i = 0; i < size; i++) {
		if (arr[i] > max) max = arr[i];
		if (arr[i] < min) min = arr[i];
	}
	
	//cout << "\nMin = " << min << "\nMax = " << max;
}
*/

//task 5
/*
void sortArr(int arr[])
{
	for (int i = 0; i < n; i++) {
		for (int j = i + 1; j < n; j++) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}

bool binary(int arr[], int key,int size)
{
	int indBegin = 0, indEnd = size;
	while (indBegin < indEnd) {
		int indMid = (indBegin + indEnd) / 2;
		if (arr[indMid] == key) {
			return true;
		}
		if (arr[indMid] < key) {
			indBegin = indMid + 1;
		}
		else {
			indEnd = indMid - 1;
		}
	}
	return false;
}
*/

//task 6



int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//1 square();
	//2 proste(4);
	//3 func(16);
	//4
	/*
	
	int arr[n];
	for (int i = 0; i < n; i++) {
		arr[i] = rand() % 10 + 1;
	}

	for (int element : arr) {
		cout.width(5);
		cout << element;
	}
	int minmax[2]{ 0 };
	mas(arr, n, minmax);
	cout << "\nMin = " << minmax[0] << "\nMax = " << minmax[1];
	int minMain, maxMain;
	mas(arr, n, minMain, maxMain);
	cout << "\nMin = " << minMain << "\nMax = " << maxMain;
	*/
	
	//5
	/*
	int arr[n];
	for (int i = 0; i < n; i++) {
		arr[i] = rand() % 10 + 1;
	}

	sortArr(arr);

	cout << "\nМасив\n";
	for (int element : arr) {
		cout.width(5);
		cout << element;
	}

	if (binary(arr, 1,n)) {
		cout << "\nЧисло знайдене";
	}
	else {
		cout << "\nЧисло не знайдене";
	}
	*/

	//6
	const int row = 5, col = 5;
	int arr[row][col];

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 10 + 1;
		}
	}

	cout << "\nМасив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}
}
