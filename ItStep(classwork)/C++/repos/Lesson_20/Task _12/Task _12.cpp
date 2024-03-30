#include <iostream>
#include <direct.h>
using namespace std;

void changeDir(char*& current, int maxlen)
{
	char* new_dir = new char[maxlen];
	cout << "Ввдіть новий шлях: ";
	cin.getline(new_dir, maxlen);

	if (_chdir(new_dir) == -1) {
		current = new_dir;
	}

	delete[] new_dir;
}

int main()
{
	setlocale(0, "");

	int maxlen = 300;
	char* cur_path = new char[maxlen] {0};

	int n;
	do {
		if (_getcwd(cur_path, maxlen) != NULL) {
			cout << "Поточний каталог: " << cur_path << endl;
		}
		else {
			cout << "Поточний каталог недосяжний!" << endl;
		}

		cout << "1 - change_dir\n2 - all_dir\n3 - all_files\n4 - new_dir\n0 - exit\n: ";
		cin >> n;
		cin.ignore();

		if (n == 0) break;

		switch (n) {
		case 1:
			changeDir(cur_path, maxlen);

			break;
		case 2:
			system("dir /ad/-N");
			system("dir /ad/-N > doc.txt");
			break;
		case 3:
			system("dir /b");

			break;
		case 4:
			_mkdir("name");

			break;
		}

		cout << endl;
		system("pause");

		system("cls");
	} while (14);

	cout << endl;
	system("pause");

	delete[] cur_path;
}