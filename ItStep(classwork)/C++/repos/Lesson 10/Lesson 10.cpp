#include <iostream>
#include <ctime>
#include <cassert>
#include <algorithm>
using namespace std;

typedef int* pointer;

void NewArr(pointer arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 - 3;
	}
}

void PrintArr(pointer arr, int size)
{
	cout << endl;
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
}

void SortArr(pointer arr, int size)
{
	for (int i = 0; i < size-1; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}

//task 1
/*
double add(double x, double y)
{
	return x + y;
}
double subtract(double x, double y)
{
	return x - y;
}
double mnozh(double x, double y)
{
	return x * y;
}
double dil(double x, double y)
{
	if (fabs(y) <= 1E-6) {//1*10^-6
		cerr << "!!!!!";
		return 0;
	}
	return x / y;
}
*/

/*
double calc(double a,double b) {
	double (*calculator[4])(double, double) { add, subtract, mnozh, dil };

	int a, b;
	cout << "Введіть по черзі значення 2 чисел\n";
	cin >> a >> b;

	int operation;
	
	cout << "\nВведіть операцію\n(1 - '+', 2 - '-', 3 - '*', 4 - '/'): ";
	cin >> operation;
	assert(operation >= 1 && operation <= 4 && "Error: operation");

	return calculator[operation - 1](a, b);
}
*/

//task 2
/*
int* BinarySerach(pointer arr, int size, int target)
{
	int left = 0, right = size - 1, mid;
	while (left <= right) {
		mid = left + (right - left) / 2;
		if (arr[mid] == target) {
			return arr+ mid;
		}
		else if (arr[mid] < target) {
			left = mid + 1;
		}
		else {
			right = mid - 1;
		}
	}

	return NULL;
}


pointer BinarySerach(pointer arr, int size, int target,int left ,int right )
{
	if (left > right) return NULL;
	int mid = left + (right - left) / 2;
	if (arr[mid] == target) return &arr[mid];//arr + mid;
		
	if (arr[mid] < target) {
			left = mid + 1;
		}
		else {
			right = mid - 1;
		}
	return BinarySerach(arr,size,target, left,right);
}
*/

//task 3
pointer ArrBil0(pointer arr, int size)
{
	pointer new_arr = new int[3];
	for (int i = 0, j = 0; i < size; ++i) {
		if (arr[i] > 0) {
			new_arr[j] = arr[i];
			if (j == 2) {
				return new_arr;
				break;
			}
			++j;
		}
	}
}
pointer ArrLast3(pointer arr, int size)
{
	pointer new_arr = new int[3];
	for (int i = size - 3 , j = 0; i < size; ++i) {
		new_arr[j] = arr[i];
		++j;
	}

	return new_arr;
}
pointer ArrMin3(pointer arr, int size)
{
	pointer new_arr = new int[3];
	if (size < 3) return NULL;
	SortArr(arr, size);
	for (int i = 0, j = 0; i < 3; ++i, ++j) {
		new_arr[j] = arr[i];
	}
	
	return new_arr;
}

pointer action(pointer(*operation)(pointer , int ), pointer arr, int size) {
	return operation(arr, size);
}
int main()
{
	srand((unsigned)time(NULL));
	setlocale(0, "");

	//task 1
	/*
	double (*calculator[4])(double, double) { add, subtract, mnozh, dil };

	int a, b;
	cout << "Введіть по черзі значення 2 чисел\n";
	cin >> a >> b;

	int operation;
	do {
		cout << "\nВведіть операцію\n(1 - '+', 2 - '-', 3 - '*', 4 - '/'): ";
		cin >> operation;
	} while (operation < 1 || operation>4);
	double rezult = calculator[operation - 1](a, b);
	//double rezult = calc(a, b);
	cout << "\nРезультат: " << rezult;
	*/

	//task 2
	/*
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;

	pointer arr = new int[size];
	NewArr(arr, size);
	PrintArr(arr, size);

	SortArr(arr, size);
	PrintArr(arr, size);

	int target;
	cout << "\n\nВведіть шуканий елемент: ";
	cin >> target;

	int rezult = BinarySerach(arr, size, target);
	if (rezult == NULL) cout << "Елемент не знайдено!\n";
	else cout << "Елемент знайдено\n";
	*/

	//task 3
	int size;
	cout << "Введіть к-сть елементів: ";
	cin >> size;

	pointer arr = new int[size];
	NewArr(arr, size);
	
	cout << "Масив";
	PrintArr(arr, size);

	int choice;
	cout << "\n1 - перші 3 > 0\n2 - значення останніх 3\n3 - найменші 3\n: ";
	cin >> choice;

	pointer(*user[])(pointer, int) { ArrBil0, ArrLast3, ArrMin3 };
	pointer new_arr = action(user[choice - 1], arr, size);
	PrintArr(new_arr, 3);

	cout << endl;
	system("pause");
}