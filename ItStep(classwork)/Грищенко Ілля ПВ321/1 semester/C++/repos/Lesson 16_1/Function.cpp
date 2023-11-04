#include "Function.h"

//int
void InitInt(int* arr, int size)
{
	srand((unsigned)time(NULL));
	for (int i = 0; i < size; ++i) {
		arr[i] = rand() % 10 - 3;
	}
}
void ShowInt(int* arr, int size)
{
	cout << endl;
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
	cout << endl;
}
int MinInt(int* arr, int size)
{
	int min = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] < min) min = arr[i];
	}

	return min;
}
int MaxInt(int* arr, int size)
{
	int max = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] > max) max = arr[i];
	}

	return max;
}
void SortInt(int* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}
void EditInt(int* arr, int size, int new_value, int index)
{
	arr[index] = new_value;
}

//double
void InitDouble(double* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = (double)rand() / 10 - 3;
	}
}
void ShowDouble(double* arr, int size)
{
	cout << endl;
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
	cout << endl;
}
double MinDouble(double* arr, int size)
{
	double min = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] < min) min = arr[i];
	}

	return min;
}
double MaxDouble(double* arr, int size)
{
	double max = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] > max) max = arr[i];
	}

	return max;
}
void SortDouble(double* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}
void EditDouble(double* arr, int size, double new_value, int index)
{
	arr[index] = new_value;
}

//char
void InitChar(char* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i] = (char)(rand() % 255);
	}
}
void ShowChar(char* arr, int size)
{
	cout << endl;
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << ' ';
	}
	cout << endl;
}
char MinChar(char* arr, int size)
{
	char min = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] < min) min = arr[i];
	}

	return min;
}
char MaxChar(char* arr, int size)
{
	char max = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] > max) max = arr[i];
	}

	return max;
}
void SortChar(char* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}
void EditChar(char* arr, int size, char new_value, int index)
{
	arr[index] = new_value;
}