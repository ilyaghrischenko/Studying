#include <iostream>
#include <ctime>
#define N 10
#define K 3
using namespace std;

//task 1
/*
double stepen(double number, int power)
{
	if (power == 0) return 1;
	if (power == 1) return number;

	return number * stepen(number, power - 1);
}
*/

//task 2
/*
void zir(int n)
{
	if (n == 0 || n < 0) return;
	cout << "* ";
	zir(n - 1);
}
*/

//task 3
/*
int suma(int a, int b,int sum = 0)
{
	if (a > b) return sum;
	
	return suma(a + 1, b,a+sum);
}
*/

//task 4
/*
int sum10(int arr[], int n, int sum = 0)
{
	if (n == 0) return sum;
	return sum10(arr, n - 1, sum + arr[n - 1]);
}

void show(int arr[], int n, int i = 0)
{
	if (i == n) {
		cout << endl;
		return;
	}
	cout << arr[i] << " ";
	show(arr, n, i + 1);
}

int findMin(int a[],int i, int size, int min, int ind) {
	if (size - i < 10) return ind;
	int buf = sum10(a, 10);
	show(a, 10);
	cout << "min= " << min << endl;
	if (buf < min) {
		min = buf;
		ind = i;
	}
	return findMin(a + 1, i + 1, size, min, ind);
}

int indMin(int a[], int n) {
	int min = sum10(a, 10);
	show(a, 10);
	return findMin(a + 1,1, n, min, 0);
}
*/

//task 6
/*
template<typename T>
int findMaxIndex(T arr[], int size)
{
	int ind = 0;
	T max = arr[ind];
	for (int i = 1; i < size; i++) {
		if (max < arr[i]) {
			max = arr[i];
			ind = i;
		}
	}
	return ind;
}
*/

//task 7
int min(int a, int b)
{
	return (a < b) ? a : b;
}

int min(int a, int b, int c)
{
	int m = (a < b) ? a : b;
	return (m < c) ? m : c;
}

int min(int arr[], int size)
{
	int min = arr[0];
	for (int i = 1; i < size; i++) {
		if (min > arr[i]) min = arr[i];
	}
	return min;
}

int min(int arr[][N], int size)
{
	int min = arr[0][0];
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < N; j++) {
			if (min > arr[i][j]) min = arr[i][j];
		}
	}
	return min;
}

int min(int arr[][N][K], int size)
{
	int min = arr[0][0][0];
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < N; j++) {
			for (int k = 0; k < K; k++) {
				if (min > arr[i][j][k]) min = arr[i][j][k];
			}
		}
	}
	return min;
}

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//task 1
	/*
	cout << stepen(4, 2);
	*/

	//task 2
	/*
	zir(4);
	*/

	//task 3
	/*
	cout << suma(1, 3);
	*/

	//task 4
	/*
	const int size = 100;
	int arr[size]{ 0 };

	for (int i = 0; i < size; i++) {
		arr[i] = rand() % 10 + 1;
	}

	cout << "\nArray\n";
	int ind = indMin(arr, size);
	cout << "index= " << ind << endl;
	*/

	//task 6
	/*
	const int size = 7;
	int arr[size]{ 0 };

	for (int i = 0; i < size; i++) {
		arr[i] = rand() % 10 + 1;
	}

	cout << "\nArray\n";
	for (int element : arr) {
		cout << element << "  ";
	}

	cout << endl << "ind max = " << findMaxIndex<int>(arr, size);
	*/
}