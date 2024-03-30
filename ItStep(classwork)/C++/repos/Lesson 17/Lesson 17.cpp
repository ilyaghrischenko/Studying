#include <iostream>
#include <fstream>
using namespace std;

int main()
{
	setlocale(0, "");

	//istream -> ifstream
	//ostream -> ofstream

	//1
	//ifstream fcin("info.txt");

	//2
	/*ifstream fcin1;
	fcin1.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\info.txt");
	if (!fcin1.is_open()) {
		cerr << "Помилка. Файл не відкритий\n";
		system("pause");
		return 1;
	}*/

	/*char word[20]{ "" };
	while (fcin1 >> word) {
		cout << word << "\n";
	}*/

	/*cout << "\nstring:\n";

	char str[512]{ "" };
	while (fcin1.getline(str, 512, '.')) {
		cout << str + 1 << "\n";
	}

	ofstream fout("infoWrite.txt");
	if (fout.fail()) {
		cerr << "Error\n";
		system("pause");
		return 1;
	}
	cout << "\nstring:\n";
	while (fcin1.getline(str, 512, '.')) {
		if (str[0] == ' ') {
			cout << str + 1 << endl;
			fout << str + 1 << endl;
		}
		else {
			cout << str << endl;
			fout << str << endl;
		}
	}

	fcin1.close();
	
	*/

	
	
	ifstream fin;
	ofstream fout;

	//task 1
	/*
	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task1\\first.txt");
	fout.open(".\\task1\\second.txt");
	if (!fin.is_open()) {
		cerr << "Error\n";
		system("pause");
		return 1;
	}

	char str[200]{ "" };
	while (fin.getline(str, 200, ' ')) {
		if (strlen(str) >= 7) fout << str << " ";
	}
	*/

	//task 2
	/*
	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task2\\first.txt");
	fout.open(".\\task2\\second.txt");

	char str[500]{ "" };
	while (fin.getline(str, 500)) {
		fout << str << endl;
	}

	fin.close();
	fout.close();
	*/

	//task 3
	/*
	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task3\\first.txt");

	char str[500]{ "" };
	int kilk = 0;
	while (fin.getline(str, 500)) {
		for (int i = 0; i < strlen(str); ++i) {
			if (isalpha(str[i])) ++kilk;
		}
	}

	cout << "\nКількість цифр: " << kilk;

	fin.close();
	*/

	//task 4
	/*
	char sym;
	cout << "Введіть символ: ";
	cin >> sym;

	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task4\\first.txt");
	
	char str[500]{ "" };
	int kilk = 0;
	while (fin.getline(str, 500, ' ')) {
		if (str[0] == sym) ++kilk;
	}

	cout << "\nКількість слів, які починаються на '" << sym << "': " << kilk;
	fin.close();
	*/

	//task 5
	/*
	ifstream bad;

	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task5\\first.txt");
	bad.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task5\\bad_words.txt");
	fout.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\task5\\second.txt");

	char str[500]{ "" };
	char bad_words[500]{ "" };

	bool isEst;
	while (bad.getline(bad_words, 500, ' ')) {
		cout << bad_words << endl;
		isEst = false;
		while (fin.getline(str, 500, ' ')) {
			cout << str << " " << endl;
			if (strcmp(str, bad_words) == 0) {
				isEst = true;
				break;
			}
		}
		fin.seekg(0);
		if (isEst==false) {
			fout << str << " ";
			cout << str << endl;
		}
	}

	fin.close();
	bad.close();
	fout.close();
	*/

	cout << endl;
	system("pause");
}