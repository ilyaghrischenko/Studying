#include <iostream>
#include <ctime>
using namespace std;

typedef int* pointer;

/*
void mySwap(pointer pA, pointer pB)
{
	int buf = *pA;
	*pA = *pB;
	*pB = buf;
	cout << "MySwap " << *pA << " " << *pB << endl;
}

void mySwap(int& a, int& b)
{
	int buf = a;
	a = b;
	b = buf;
	cout << "MySwap " << a << " " << b << endl;
}

void showArr(pointer a, int size) {
	for (int i = 0; i < size; ++i) {
		cout << a[i] << "  ";
	}
	cout << endl;
}

pointer newArr(pointer a, int size)
{
	if (size < 3) return NULL;
	pointer ret = new int[3];
	ret[0] = a[0];
	ret[1] = a[size / 2];
	ret[2] = a[size - 1];

	return ret;
}
*/

void NewArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 - 5;
	}
}

void printArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
	cout << endl;
}

void sortArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}

//task 1
/*
void SumDobArr(pointer arr, int size, int& sum, long& dob)
{
	sum = 0;
	dob = 1;

	for (int i = 0; i < size; ++i) {
		sum += arr[i];
		dob *= arr[i];
	}
	
}

void SumDobArr(pointer arr, int size, int* sum, long* dob)
{
	*sum = 0;
	*dob = 1;

	for (int i = 0; i < size; ++i) {
		*sum += arr[i];
		*dob *= arr[i];
	}

}
*/

//task 2
/*
pointer kilk(pointer arr, int size, int& k_v, int& k_d, int& k_0)
{
	pointer mas = new int[3];

	k_v = 0, k_d = 0, k_0 = 0;
	for (int i = 0; i < size; ++i, ++arr) {
		if (*arr == 0) ++mas[0];
		else if (*arr < 0) ++mas[1];
		else if (*arr > 0) ++mas[2];
	}
	arr -= size;

	return mas;
}
*/

//task 3
/*
pointer isPlural(pointer arr1, pointer arr2, int size1, int size2)
{
	pointer position_plural = NULL;

	for (int i = 0; i < size2; ++i) {
		for (int j = 0; j < size1; ++j) {
			if (arr2[i] != arr1[j]) return NULL;
		}
	}


	for (int j = 0; j < size1; ++j) {
		if (arr2[0] == arr1[j]) {
			position_plural = arr2 + j;
			return position_plural;
		}
	}
}
*/

//task 4
/*
pointer delVid(pointer arr, int size, int& k_d)
{
	k_d = 0;
	for (int i = 0; i < size; ++i) {
		if (arr[i] >= 0) ++k_d;
	}

	pointer newArr = new int[k_d] {0};
	for (int i = 0, j = 0; i < size; ++i) {
		if (arr[i] >= 0) {
			newArr[j] = arr[i];
			++j;
		}
	}
	
	return newArr;
}
*/

//task 5
/*
pointer Mas(pointer arr1, pointer arr2, int size1, int size2, int& size)
{
	size = size1 + size2;
	pointer newArr = new int[size];
	
	for (int i = 0, j = 0; i < size; ++i) {
		if (i < size1) newArr[i] = arr1[i];
		else {
			newArr[i] = arr2[j];
			++j;
		}
	}

	delete[] arr1;

	return newArr;
}
*/

int main()
{
	srand((unsigned)time(NULL));
	setlocale(0, "");

	/*
	int a = 6, b = 8;
	cout << a << " " << b << endl;
	mySwap(a, b);
	cout << a << " " << b << endl;
	mySwap(&a, &b);
	cout << a << " " << b << endl;

	int arr1[7]{ 0 };//const int*
	pointer arr2 = new int[8]{ 0 };
	showArr(arr1, 7);
	showArr(arr2, 8);

	pointer rez = newArr(arr1, 7);
	if (rez == NULL) {
		cerr << "Error";
		return 1;
	}
	else {
		for (int i = 0; i < 3; ++i) {
			cout << rez[i] << "  ";
		}
	}
	*/

	//task 1
	/*
	int sum = 0;
	long dob = 1;

	int size;
	cout << "Введiть к-сть елементiв: " << endl;
	cin >> size;

	pointer arr = new int[size] {0};
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 + 1;
	}

	cout << "\nМасив\n";
	printArr(arr, size);

	SumDobArr(arr, size, &sum, &dob);
	cout << "\nСума = " << sum << "\nДобуток = " << dob << endl;
	delete[] arr;
	*/

	//task 2
	/*
	int size;
	cout << "Введiть к-сть елементiв: ";
	cin >> size;

	pointer arr = new int[size];
	for (int i = 0; i < size; ++i, ++arr) {
		*arr = rand() % 10;
	}
	arr -= size;

	printArr(arr, size);
	int k_v = 0, k_d = 0, k_0 = 0;

	pointer mas = new int[3];

	kilk(arr, size, k_v, k_d, k_0);
	cout << "К-сть додатних = " << mas[0] << endl << "К-сть вiд'ємних = " << mas[1] << endl << "К-сть 0 = " << mas[2] << endl;

	delete[] arr;
	*/

	//task 3
	/*
	int n, m;
	cout << "Введiть к-сть елементiв A: ";
	cin >> n;
	cout << "Введiть к-сть елементiв B: ";
	cin >> m;

	pointer A = new int[n];
	NewArr(A, n);

	pointer B = new int[n];
	NewArr(B, m);

	cout << "\nМасив A\n";
	printArr(A, n);

	cout << "\nМасив B\n";
	printArr(B, m);

	sortArr(A, n);
	sortArr(B, m);

	cout << "\nВiдсортований масив А\n";
	printArr(A, n);

	cout << "\nВiдсортований масив А\n";
	printArr(B, m);

	if (isPlural(A, B, n, m) == NULL) cout << "\nВ не є пiдмножиною А\n";
	else cout << "\nПерше входження пiдмонижини В у множину А стоїть на " << isPlural(A, B, n, m) << " мiсцi\n";
	*/

	//task 4
	/*
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;

	pointer arr = new int[size] {0};
	NewArr(arr, size);

	cout << "\nПочатковий масив\n";
	printArr(arr, size);
	int k_d;
	int* newArr=delVid(arr, size, k_d);
	cout << "Змінений масив\n";
	printArr(newArr, k_d);

	delete[] arr, newArr;
	*/

	//task 5
	/*
	int size1, size2;
	cout << "Введіть к-сть елементів для 1 і 2 масиву по черзі\n:";
	cin >> size1 >> size2;

	pointer arr1 = new int[size1];
	pointer arr2 = new int[size2];
	NewArr(arr1, size1);
	NewArr(arr2, size2);

	cout << "\nПерший масив\n";
	printArr(arr1, size1);
	cout << "Другий масив\n";
	printArr(arr2, size2);

	int size = 0;
	arr1 = Mas(arr1, arr2, size1, size2, size);
	printArr(arr1, size);
	*/
}