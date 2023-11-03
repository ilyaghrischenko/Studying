#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

class Human {
private:
	char* pib;
	int age;
public:
	Human()
	{
		pib = new char[7] {"No PIB"};
		age = 0;
	}
	Human(const char* pib, int age):age(age)
	{
		strcpy(this->pib = new char[strlen(pib) + 1], pib);
	}
	Human(Human& x)
	{
		strcpy(pib = new char[strlen(x.pib) + 1], x.pib);
		age = x.age;
	}
	Human& operator=(Human& x)
	{
		if (pib != nullptr) delete[] pib;
		pib = new char[strlen(x.pib) + 1];
		strcpy(pib, x.pib);
		age = x.age;

		return *this;
	}
	~Human()
	{
		if (pib != nullptr) delete[] pib;
	}

	inline char* GetPib() const
	{
		return pib;
	}
	inline void SetPib(const char* pib)
	{
		strcpy(this->pib, pib);
	}

	inline int GetAge() const
	{
		return age;
	}
	inline void SetAge(int age)
	{
		this->age = age;
	}

	inline void input()
	{
		char s[512];
		cout << "ПІБ: ";
		cin.getline(s, 512);
		strcpy(pib = new char[strlen(s) + 1], s);

		cout << "Вік: ";
		cin >> age;
		cin.ignore();

		cout << endl;
	}
	inline void show() const
	{
		cout << "ПІБ: " << pib << " | Вік: " << age << endl;
	}
};

class Apartment {
private:
	int number;
	int kilk_peoples;
	Human** people;
public:
	Apartment()
	{
		number = 0;
		kilk_peoples = 0;
		people = nullptr;
	}
	Apartment(int number, int kilk_peoples, Human** people) :number(number), kilk_peoples(kilk_peoples)
	{
		this->people = new Human* [kilk_peoples];
		this->people = people;
	}
	Apartment(Apartment& x)
	{
		number = x.number;
		kilk_peoples = x.kilk_peoples;
		people = new Human* [x.kilk_peoples];
		people = x.people;
	}
	Apartment& operator=(Apartment& x)
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) delete[] people[i];
			delete[] people;
		}
		people = new Human* [x.kilk_peoples];
		number = x.number;
		kilk_peoples = x.kilk_peoples;
		people = x.people;

		return *this;
	}
	~Apartment()
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) {
				people[i]->~Human();
				delete[] people[i];
			}
			delete[] people;
		}
	}

	inline int GetNumber() const
	{
		return number;
	}
	inline void SetNumber(int number)
	{
		this->number = number;
	}

	inline int GetKilkPeoples() const
	{
		return kilk_peoples;
	}
	//не зробив сеттер зі зміною розміру, тому що на парі з цим проблеми були

	inline Human** GetPeople() const
	{
		return people;
	}
	void SetPeople()
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) delete[] people[i];
			delete[] people;
		}
		people = new Human* [kilk_peoples];
		for (int i = 0; i < kilk_peoples; ++i) {
			people[i] = new Human;
			people[i]->input();
		}
	}

	void input()
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) delete[] people[i];
			delete[] people;
		}

		cout << "Введіть номер квартири: ";
		cin >> number;

		cout << "Введіть кількість людей: ";
		cin >> kilk_peoples;

		cout << endl;

		cin.ignore();

		cout << "Масив людей:\n";
		people = new Human* [kilk_peoples];
		for (int i = 0; i < kilk_peoples; ++i) {
			cout << i + 1 << " людина)\n";
			people[i] = new Human;
			people[i]->input();
		}
	}
	void show() const
	{
		cout << "Номер квартири: " << number << " | Кількість людей: " << kilk_peoples << endl;
		cout << "Масив людей:\n";
		for (int i = 0; i < kilk_peoples; ++i) people[i]->show();
	}
};

int main()
{
	setlocale(0, "");

	Apartment kvart;
	kvart.input();
	kvart.show();

	cout << endl;
	system("pause");
}