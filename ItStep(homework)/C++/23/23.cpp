#include <iostream>
#include <fstream>
#include <string>
using namespace std;

//task 1
/*
void IsEqual(const string& first, const string& second)
{
	fstream file1, file2;
	string str1{ "" };
	string str2{ "" };

	try {
		file1.open(first);
		file2.open(second);
		if (!file1.is_open() || !file2.is_open()) throw exception("Помилка! Файл не відкрився!");
		//if (getline(file1, str1) || getline(file2, str2)) throw exception("Файли мають різну кількість рядків.");
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

	file1.close();
	file2.close();
	cout << "\nРядки збігаються!\n";
}
*/

//task 2
/*
void WriteStatictics(const string& from, const string& in)
{
	fstream inFile;
	fstream outFile;
	string line{ "" };

	try {
		inFile.open(from);
		outFile.open(in, ios::out | ios::trunc);
		if (!inFile.is_open() || !outFile.is_open()) throw exception("Помилка! Файл не відкрився.");
	}
	catch (exception& error) {
		cout << error.what() << endl;
		return;
	}

	int kilk_char = 0;
	int kilk_line = 0;
	int kilk_word = 0;

	while (getline(inFile, line)) {
		++kilk_line;
		kilk_char += line.length();

		bool isWord = false;
		for (char var : line) {
			if (isspace(var)) isWord = false;
			else if (!isWord) {
				isWord = true;
				++kilk_word;
			}
		}


	}
	outFile << "К-сть символів: " << kilk_char << endl;
	outFile << "К-сть рядків: " << kilk_line << endl;
	outFile << "К-сть слів: " << kilk_word;

	inFile.close();
	outFile.close();
}
*/

//task 3
/*
void CaesarsCipher(const string& start, const string& end, int key)
{
	fstream inFile;
	fstream outFile;
	string line{ "" };

	try {
		inFile.open(start);
		outFile.open(end, ios::out | ios::trunc);
		if (!inFile.is_open() || !outFile.is_open()) throw exception("Помилка! Файл не відкрився.");
	}
	catch (exception& error) {
		cout << error.what() << endl;
		return;
	}

	while (getline(inFile, line)) {
		for (int i = 0; i < line.length(); ++i) {
			line[i] += key;
			outFile << line[i];
		}
		cout << endl;
	}

	inFile.close();
	outFile.close();
}
*/

int main()
{
	setlocale(0, "");

	//task 1
	/*
	string file1{ "first.txt" };
	string file2{ "second.txt" };
	IsEqual(file1, file2);
	*/

	//task 2
	/*
	string file1{ "task2(1).txt" };
	string file2{ "task2(2).txt" };
	WriteStatictics(file1, file2);
	*/

	//task 3
	/*
	string file1{ "task3(1).txt" };
	string file2{ "task3(2).txt" };
	CaesarsCipher(file1, file2, 2);
	*/

	cout << endl;
	system("pause");
}