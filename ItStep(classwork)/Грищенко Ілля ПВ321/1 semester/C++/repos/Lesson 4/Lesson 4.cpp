#include <iostream>
#include <ctime>
#include <math.h>
using namespace std;

int main()
{
	//srand((unsigned)time(NULL));
	setlocale(0, "");
	//task 1
	/*
	const int n = 6;
	double arr[n], sum = 0;
	for (int i = 0; i < n; i++) {
		cout << "Введiть прибуток за " << i + 1 << " мiсяць: ";
		cin >> arr[i];
	}

	for (double element : arr) {
		sum += element;
	}

	cout << endl;
	system("pause");
	for (int i = 0; i < n; i++) {
		cout << i + 1 << " мiсяць - " << arr[i]<<endl;
	}

	cout << "\n\nСума прибутку за 6 мiсяцiв = " << sum << endl;
	*/

	//task 2
	/*
	const int n = 10;
	int arr[n];

	for (int i = 0; i < n; i++) {
		arr[i] = (int)rand() % 90 + 10;
	}

	cout << "\nArray\n";
	for (int element : arr) {
		cout << element << "  ";
	}

	cout << "\nReversed\n";
	for (int i = n - 1; i >= 0; i--) {
		cout << arr[i] << "  ";
	}
	*/

	//task 3
	/*
	const int n = 6;
	double arr[n];

	for (int i = 0; i < n; i++) {
		cout << "Введіть " << i + 1 << " сторону: ";
		cin >> arr[i];
	}

	cout << "\nArray\n";
	for (double element : arr) {
		cout << element << "  ";
	}

	double per = 0;
	for (double element : arr) {
		per += element;
	}

	cout << "\n\nПериметр = " << per << endl;
	*/

	//task 4
	/*
	const int n = 10;
	int arr[n];

	for (int i = 0; i < n; i++) {
		arr[i] = (int)rand() % 90 + 10;
	}

	cout << "\nArray\n";
	for (int element : arr) {
		cout << element << "  ";
	}

	int mx = arr[0], mn = arr[0];

	for (int element : arr) {
		if (element > mx) mx = element;
	}

	for (int element : arr) {
		if (element < mn) mn = element;
	}


	cout << "Max - " << mx << endl << "Min - " << mn;
	*/

	//task 5
	/*
	const int n = 12;
	double arr[n];

	for (int i = 0; i < n; i++) {
		cout << "Введіть прибуток за " << i + 1 << " місяць: ";
		cin >> arr[i];
	}

	cout << "\nArray\n";
	for (double element : arr) {
		cout << element << "  ";
	}

	double max = arr[n-1], min = arr[n-1];
	int index_max = n-1, index_min = n-1;
	for (int i = 0; i < n; i++) {
		if (arr[i] > max) {
			max = arr[i];
			index_max = i;
		}
		if (arr[i] < min) {
			min = arr[i];
			index_min = i;
		}
	}

	cout << "\n\nМаксимальний прибуток був в " << index_max + 1 << " місяці";
	cout << "\nМінімальний прибуток був в " << index_min + 1 << " місяці\n";
	*/

	//task 6
	/*
	const int n = 10;
	int arr[n];

	for (int i = 0; i < n; i++) {
		cout << "Введіть " << i + 1 << " елемент: ";
		cin >> arr[i];
	}

	cout << "\nЗвичайний масив\n";
	for (int element : arr) {
		cout << element << "  ";
	}
	cout << endl;

	system("pause");

	int min1 = arr[0], min2;
	int index_1 = 0, index_2 = 0;
	for (int i = 0; i < n; i++) {
		if (arr[i] < min1) {
			min1 = arr[i];
			index_1 = i;
		}
	}
	index_2 = (index_1 == 0) ? 1 : 0;
	min2 = arr[index_2];
	for (int i = 0; i < n; i++) {
		if (index_1 == i) continue;
		if (arr[i] < min2) {
			min2 = arr[i];
			index_2 = i;
		}
	}

	cout << "\nПерше мінімальне число - " << min1 << endl << "Друге мінімальне число - " << min2 << endl;

	if (index_2 < index_1) swap(index_2, index_1);
	if (((index_2) - (index_1)) > 5) {
		for (int i = index_1; i < index_2 - 1; i++) {
			for (int j = i + 1; j > index_1 && arr[j] < arr[j - 1]; j--) {
				swap(arr[j], arr[j - 1]);
			}
		}
	}

	cout << "\nВідсортований масив\n";
	for (int element : arr) {
		cout << element << "  ";
	}
	cout << endl;

	//task 7 lfdlf
	/*
	const int n = 5;
	int arr[n];

	for (int i = 0; i < n; i++) {
		cout << "Введіть " << i + 1 << " Елелемнт: ";
		cin >> arr[i];
	}

	cout << "\nМасив\n";
	for (int element : arr) {
		cout << element << "  ";
	}

	for()

	cout << "\nОновлений масив\n";
	for (int element : arr) {
		cout << element << "  ";
	}
	*/

	//task 7
	

	//task 8
	/*
	const int n = 20;
	int a[n];

	for (int i = 0; i < n; i++) {
		cout << "Введіть " << i + 1 << " елемент(+/-): ";
		cin >> a[i];
	}

	cout << "\nМасив\n";
	for (int element : a) {
		cout << element << "  ";
	}

	int sum_d = 0, sum_v = 0;
	for (int i = 0; i < n; i++) {
		if (a[i] < 0) sum_v++;
		if (a[i] >= 0) sum_d++;
	}
	
	cout << "Сума дод = " << sum_d << endl << "Сума від = " << sum_v;

	if (abs(sum_d) > abs(sum_v)) {
		for (int i = 0; i < n; i++) {
			if (a[i] < 0) a[i] *= -2;
		}
	}

	cout << "\nОновлений масив\n";
	for (int element : a) {
		cout << element << "  ";
	}
	*/
}