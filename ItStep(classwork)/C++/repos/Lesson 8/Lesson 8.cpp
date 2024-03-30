#include <iostream>
#include <ctime>
using namespace std;

typedef int* pointer;

void sortArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	/*

	type* namePointer;



	int* pInt;
	int a = 5;
	pInt = &a;
	a++;
	++* pInt;
	cout << "a = " << a << " : " << pInt << " : " << *pInt << endl;
	int arr[]{ 23, 12, 5, 6, 12 };
	pInt = arr; //&arr[0];
	cout << *pInt << " " << *(pInt + 1) << endl;
	for (int i = 0; i < 5; i++, pInt++) {
		cout << *pInt << " ";
	}
	pInt--;
	for (int i = 0; i < 5; i++, pInt--) {
		*pInt += 2;
		cout << *pInt << " ";
	}
	*/

	//task 1
	/*
	int first = rand() % 10 + 1, second = rand() % 10 + 1;
	pointer adress1 = &first, adress2 = &second, max;

	max = (*adress1 > *adress2) ? adress1 : adress2;
	cout << "Найбільше число з (" << *adress1 << ", " << *adress2 << ") = " << *max;
	*/

	//task 2
	/*
	int x = rand() % 10 + 1, y = rand() % 10 + 1;
	pointer pX = &x, pY = &y, buf;

	cout << "Початкове значення змінних - " << *pX << ", " << *pY;

	buf = pX;
	pX = pY;
	pY = buf;

	cout << "\nФінальне значення змінних - " << *pX << ", " << *pY;
	*/

	//task 3
	/*
	const int size = 5;
	int arr[size];
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 + 1;
	}

	for (int element : arr) {
		cout << element << "  ";
	}

	pointer pArr = arr;
	int sum = 0;
	for (int i = 0; i < size; ++i, ++pArr) {
		sum += *pArr;
	}

	cout << "Sum = " << sum;
	*/

	/*
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;

	pointer pInt = new int[size] {0};
	if (pInt == NULL) {
		cerr << "Error: memory\n";
		system("pause");
		return 1;
	}

	for (int i = 0; i < size; ++i) {
		pInt[i] = rand() % 20 + 1;
	}

	for (int i = 0; i < size; ++i, ++pInt) {
		*pInt = rand() % 20 + 1;
	}

	pInt -= size;

	for (int i = 0; i < size; ++i) {
		cout << pInt[i] << " ";
	}

	delete[] pInt;
	*/

	//task 4
	/*
	int n, m;
	cout << "Введіть значння для n і m по черзі:\n";
	cin >> n >> m;

	if (n < 0 || m < 0 || n == NULL || m == NULL) {
		cerr << "Розміри масиву можуть бути тільки більше 0";
		return 1;
	}

	pointer a = new int[m] {0}, b = new int[n] {0};

	int input;
	cout << "1 - з повторенням\n2 - без повторень\n: ";
	cin >> input;

	cout << "\n1 масив (b)\n";
	for (int j = 0; j < n; ++j) {
		b[j] = rand() % 10 + 1;
		cout << b[j] << "  ";
	}

	cout << "\n2 масив (a)\n";
	for (int i = 0; i < m; ++i) {
		a[i] = rand() % 10 + 1;
		cout << a[i] << "  ";
	}

	cout << endl;
	system("pause");

	int sum = 0;
	pointer c1 = NULL, c2 = NULL;
	
	sum = m + n;
	c = new int[sum] {0};
	int i;
	for (i = 0; i < m; ++i, ++a) {
		c[i] = *a;
	}
	a -= m;
	for (; i < sum; ++i, ++b) {
		c[i] = *b;
	}
	b -= n;

	if (input == 2) {
		int kilk_p = 0;
		for (int i = 0; i < sum; ++i) {
			for (int j = 0; j < sum; ++j) {
				if (i == j) continue;
				if (c[i] == c[j]) kilk_p++;
			}
		}

		sum -= kilk_p;
		c2 = new int[sum] {0};

		for (int i = 0; i < m; ++i, ++c) {
			*c = a[i];
		}
		c -= m;
		for (int i = 0; i < n; ++i, ++c) {
			if (b[i] != 0) *c = b[i];
		}
		c -= n;
	}
	if (c != NULL) {
		cout << "\n3 масив\n";
		for (int i = 0; i < sum; ++i) {
			cout << c[i] << "  ";
		}
	}

	delete[] a, b, c;
	cout << endl;
	*/

	//task 5
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;
	pointer arr = new int[size];

	int k_p = 0;
	for (int i = 0; i < size; ++i, ++arr) {
		*arr = rand() % 10 + 1;
		cout << *arr << "  ";
		if (*arr % 2 == 0) {
			k_p++;
			*arr = 0;
		}
	}
	arr -= size;

	pointer arrNew = new int[size - k_p];
	for (int i = 0; i < size - k_p; ++i, ++arrNew) {
		for (int j = 0; j < size; ++j, ++arr) {
			if (*arr == *arrNew) *arrNew = *arr;
		}
	}
	arr -= size;
	arrNew -= size - k_p;

	cout << endl;

	for (int i = 0; i < size - k_p; ++i, ++arrNew) {
		cout << *arrNew << "  ";
	}

	delete[] arr, arrNew;
}