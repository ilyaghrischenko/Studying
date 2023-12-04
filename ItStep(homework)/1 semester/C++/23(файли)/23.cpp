#include <iostream>
#include <fstream>
#include <string>
using namespace std;

//task 1
void IsEqual(const string& first, const string& second)
{
	fstream file1, file2;
	string str1{ "" };
	string str2{ "" };

	try {
		file1.open(first);
		file2.open(second);
		if (!file1.is_open() || !file2.is_open()) throw exception("Помилка! Файл не відкрився!");
		if (getline(file1, str1) || getline(file2, str2)) throw exception("Файли мають різну кількість рядків.");
	}
	catch (exception& error) {
		cout << error.what() << endl;
		return;
	}

	int lineNumber = 1;
	while (getline(file1, str1) && getline(file2, str2)) {
		if (str1 != str2) {
			cout << "Нерівність у " << lineNumber << " рядку:\n";
			cout << "File 1: " << str1 << "\n";
			cout << "File 2: " << str2 << "\n";
			return;
		}
		++lineNumber;
	}

	cout << "\nРядки збігаються!\n";
}

int main()
{
	setlocale(0, "");

	//task 1
	string file1{ "first.txt" };
	string file2{ "second.txt" };
	IsEqual(file1, file2);

	cout << endl;
	system("pause");
}