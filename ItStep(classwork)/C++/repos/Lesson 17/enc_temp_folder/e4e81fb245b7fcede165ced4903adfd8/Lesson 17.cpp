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

	//task 1
	ifstream fin;
	ofstream fout;

	fin.open("C:\\Users\\308-12\\Desktop\\Грищенко Ілля ПВ321\\1 semester\\C++\\repos\\Lesson 17\\txt\\first.txt");
	if (!fin.is_open()) {
		cerr << "Error\n";
		system("pause");
		return 1;
	}

	char str[200]{ "" };
	while (fin.getline(str, 200, ' ')) {
		if (strlen(str) >= 7) fout << str;
	}

	fin.close();
	fout.close();

	cout << endl;
	system("pause");
}