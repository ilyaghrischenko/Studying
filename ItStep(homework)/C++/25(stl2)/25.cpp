#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include <map>
using namespace std;

typedef map<string, vector<int>> dict;

class Test {
private:
	string path;
	int grade;
public:
	Test() :path("NoPath"), grade(0) { input(); test(); }
	Test(const string& path) :path(path), grade(0) { test(); }

	inline string GetPath() const
	{
		return path;
	}
	inline void SetPath(const string& path)
	{
		this->path = path;
	}

	inline int GetGrade() const
	{
		return grade;
	}

	inline void show() const
	{
		cout << "Файл: " << path << " | Оцінка: " << grade << endl;
	}
	inline void input()
	{
		cout << "Шлях до файлу: ";
		getline(cin, path);
	}

	void test()
	{
		vector<int> answers;
		fstream file(path + "\\answers.txt", ios::in);
		string value;
		while (getline(file, value).good()) {
			answers.emplace_back(atoi(value.c_str()));
		}
		file.close();
		value.clear();

		dict arr;
		fstream file2(path + "\\test.txt", ios::in);
		string key;
		while (getline(file2, key).good()) {
			vector<int> vect;
			while (getline(file2, value) && value != ";") {
				vect.push_back(atoi(value.c_str()));
			}
			arr.insert({key,vect});
		}
		file2.close();

		for (auto i = arr.begin(); i != arr.end(); ++i) {
			cout << i->first << endl;
			for (auto j : i->second) {
				cout << j << " ";
			}
			cout << endl;
		}
		system("pause");

		cout << "Тестування:\n";
		int kilk_prav = 0;
		int k = 0;
		for (dict::iterator i = arr.begin(); i != arr.end(); ++i, ++k) {
			int answer = 0;
			cout << i->first << endl;
			cout << "Варіанти відповіді: ";
			for (int j = 0; j < i->second.size(); ++j) {
				cout << i->second[j] << " ";
			}
			cout << endl;

			cout << "Ваша відповідь: ";
			cin >> answer;
			if (answers[k] == answer) {
				kilk_prav++;
				cout << "Правильна відповідь!";
			}
			else cout << "Відповідь не правильна!";
			cout << endl << endl;
		}

		grade = kilk_prav * 2;
	}
};

int main()
{
	setlocale(0, "");

	Test first("Tests\\Test1");
	first.test();
	first.show();

	cout << endl;
	system("pause");
}