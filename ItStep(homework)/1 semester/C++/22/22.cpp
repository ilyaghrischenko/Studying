#include <iostream>
using namespace std;

//task 1
/*
string CompressLine(const string& start)
{
	string finish;

	auto beg = start.begin();
	auto end = start.end();

	while (beg != end && isspace(*beg)) {
		++beg;
	}

	while (beg != end) {
		while (beg != end && !isspace(*beg)) {
			finish += *beg;
			++beg;
		}
		while (beg != end && isspace(*beg)) {
			++beg;
		}
		if (beg != end) {
			finish += ' ';
		}
	}

	return finish;
}
*/

//task 2
/*
template<typename T>
void PrintArr(T* arr, int size)
{
	cout << "Масив:\n";
	for (int i = 0; i < size; ++i) {
		cout << arr[i] << "  ";
	}
	cout << endl;
}

template<typename T>
T GetMax(T* arr, int size)
{
	T max = arr[0];
	for (int i = 0; i < size; ++i) {
		if (arr[i] > max) max = arr[i];
	}

	return max;
}

template<typename T>
void SortArr(T* arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size; ++j) {
			if (arr[i] > arr[j]) swap(arr[i], arr[j]);
		}
	}
}

template<typename T>
T BinarySearch(T* arr, T target, int low, int high)
{
	while (low <= high) {
		int mid = low + (high - low) / 2;

		if (arr[mid] == target) {
			return mid;
		}
		else if (arr[mid] > target) {
			high = mid - 1;
		}
		else {
			low = mid + 1;
		}
	}

	return T();
}

template<typename T>
void ChangeValue(T* arr, int new_value, int index)
{
	arr[index] = new_value;
}
*/

int main()
{
	setlocale(0, "");

	//task 1
	/*
	string start{ "   hello              world   hello " };
	string finish = CompressLine(start);
	cout << endl << start << endl;
	cout << endl << finish << endl;
	*/

	//task 2
	/*
	const int size = 6;
	int arr[size]{ 6,5,4,3,2,1 };
	PrintArr<int>(arr, size);
	cout << endl;

	cout << "Max: " << GetMax<int>(arr, size) << endl;
	cout << "Сортування...\n\n";
	SortArr<int>(arr, size);
	PrintArr<int>(arr, size);
	cout << endl;
	cout << "Шуканий елемент: 2, знайдений елемент: " << BinarySearch<int>(arr, 2, 0, size - 1) + 1 << endl;
	cout << "Зміна значення...\n\n";
	ChangeValue<int>(arr, 4, 2);
	PrintArr<int>(arr, size);
	*/

	cout << endl;
	system("pause");
}