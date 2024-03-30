#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

//task 1
/*
struct Book {
	char name[80];
	char author[80];
	char publication[80];
	char genre[80];

	void init()
	{
		cout << "Введіть назву: ";
		cin.getline(name, 80);

		cout << "Введіть автора: ";
		cin.getline(author, 80);

		cout << "Введіть видавництво: ";
		cin.getline(publication, 80);

		cout << "Введіть жанр: ";
		cin.getline(genre, 80);
	}
	void show()
	{
		cout << endl;

		cout << "Назва: " << name;
		cout << "\nАвтор: " << author;
		cout << "\nВидавництво: " << publication;
		cout << "\nЖанр: " << genre;
	}
	bool check()
	{
		int input;
		cout << "\nЧи згодні ви придбати книгу?(1 - так, 2 - ні): ";
		cin >> input;

		if (input != 1 && input != 2) {
			cerr << "Помилка! Не правильний ввід";
			system("pause");
			return 1;
		}

		if (input == 1) return true;
		return false;
	}
};
*/

//task 2
/*
struct Car {
	char mark[80];
	char color[80];
	double lenght;
	double width;
	double height;
	
	void init()
	{
		cout << "Введіть марку: ";
		cin.getline(mark, 80);

		cout << "Введіть колір: ";
		cin.getline(color, 80);

		cout << "Введіть довжину: ";
		cin >> lenght;

		cout << "Введіть ширину: ";
		cin >> width;

		cout << "Введіть висоту: ";
		cin >> height;
	}
	void show()
	{
		cout << endl;

		cout << "Марка: " << mark;
		cout << "\nКолір: " << color;
		cout << "\nДовжина: " << lenght;
		cout << "\nШирина: " << width;
		cout << "\nВисота: " << height;
	}
	bool CheckColor(char my_color[])
	{
		if (my_color == color) return true;
	}
};
*/

int main()
{
	setlocale(0, "");

	//task 1
	/*
	Book x;
	x.init();
	x.show();
	if (x.check() == true) cout << "\nВи придбали книгу";
	*/

	//task 2
	/*
	char my_color[80];
	cout << "Введіть бажаний колір: ";
	cin.getline(my_color, 80);

	cout << endl;

	Car x;
	x.init();
	x.show();
	if (x.CheckColor(my_color)) cout << "\n\nКолір машини підходить вам";
	*/

	cout << endl;
	system("pause");
}