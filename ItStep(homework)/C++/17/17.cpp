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
		strcpy(pib = new char[7], "No pib");
		age = 0;
	}
	Human(const char* pib, int age):age(age)
	{
		strcpy(this->pib = new char[strlen(pib) + 1], pib);
	}
	Human(const Human& x)
	{
		strcpy(pib = new char[strlen(x.pib) + 1], x.pib);
		age = x.age;
	}
	Human& operator=(const Human& x)
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
		if (this->pib != nullptr) delete[] this->pib;
		strcpy(this->pib = new char[strlen(pib) + 1], pib);
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
		if (pib != nullptr) delete[] pib;

		char s[512];
		cout << "ПiБ: ";
		cin.getline(s, 512);
		strcpy(pib = new char[strlen(s) + 1], s);

		cout << "Вiк: ";
		cin >> age;
		cin.ignore();
	}
	inline void show() const
	{
		cout << "ПiБ: " << pib << " | Вiк: " << age << endl;
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
	Apartment(const Apartment& x)
	{
		number = x.number;
		kilk_peoples = x.kilk_peoples;
		people = new Human* [x.kilk_peoples];
		people = x.people;
	}
	Apartment& operator=(const Apartment& x)
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) {
				delete people[i];
			}
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
				delete people[i];
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
	//не зробив сеттер зi змiною розмiру, тому що на парi з цим проблеми були

	inline Human** GetPeople() const
	{
		return people;
	}
	void SetPeople()
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) {
				delete people[i];
			}
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
			for (int i = 0; i < kilk_peoples; ++i) {
				delete people[i];
			}
			delete[] people;
		}

		cout << "Введiть номер квартири: ";
		cin >> number;

		cout << "Введiть кiлькiсть людей: ";
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
		cout << "Номер квартири: " << number << " | Кiлькiсть людей: " << kilk_peoples << endl;
		cout << "Масив людей:\n";
		for (int i = 0; i < kilk_peoples; ++i) {
			cout << i + 1 << ") ";
			people[i]->show();
		}
	}
};

class House {
private:
	char* adress;
	int kilk_floors;
	int kilk_apart;
	Apartment** apartments;
public:
	House()
	{
		strcpy(adress = new char[10], "No adress");
		kilk_floors = 0;
		kilk_apart = 0;
		apartments = nullptr;
	}
	House(const char* adress, int kilk_floors, int kilk_apart, Apartment** apartments) :kilk_floors(kilk_floors), kilk_apart(kilk_apart)
	{
		strcpy(this->adress = new char[strlen(adress) + 1], adress);
		this->apartments = new Apartment* [kilk_apart];
		this->apartments = apartments;
	}
	House(const House& x)
	{
		strcpy(adress = new char[strlen(x.adress) + 1], x.adress);
		kilk_floors = x.kilk_floors;
		kilk_apart = x.kilk_apart;
		apartments = new Apartment* [x.kilk_apart];
	}
	House& operator=(const House& x)
	{
		if (apartments != nullptr) {
			for (int i = 0; i < kilk_apart; ++i) {
				delete apartments[i];
			}
			delete[] apartments;
		}
		if (adress != nullptr) delete[] adress;
		
		strcpy(adress = new char[strlen(x.adress) + 1], x.adress);
		kilk_floors = x.kilk_floors;
		kilk_apart = x.kilk_apart;
		apartments = new Apartment* [x.kilk_apart];

		return *this;
	}
	~House()
	{
		if (apartments != nullptr) {
			for (int i = 0; i < kilk_apart; ++i) {
				delete apartments[i];
			}
			delete[] apartments;
		}
		if (adress != nullptr) delete[] adress;
	}

	inline char* GetAdress() const
	{
		return adress;
	}
	inline void SetAdress(const char* adress)
	{
		if (this->adress != nullptr) delete[] this->adress;
		strcpy(this->adress = new char[strlen(adress) + 1], adress);
	}

	inline int GetKilkFloors() const
	{
		return kilk_floors;
	}
	inline void SetKilkFloors(int kilk_floors)
	{
		this->kilk_floors = kilk_floors;
	}

	inline int GetKilkApart() const
	{
		return kilk_apart;
	}
	//

	inline Apartment** GetApartments() const
	{
		return apartments;
	}
	inline void SetApartments(Apartment** arr)
	{
		if (apartments != nullptr) {
			for (int i = 0; i < kilk_apart; ++i) {
				delete apartments[i];
			}
			delete[] apartments;
		}
		apartments = new Apartment* [kilk_apart];
		for (int i = 0; i < kilk_apart; ++i) {
			cout << i + 1 << " квартира.\n";
			apartments[i] = new Apartment;
			apartments[i]->input();
		}
	}

	inline void input()
	{
		if (apartments != nullptr) {
			for (int i = 0; i < kilk_apart; ++i) {
				delete apartments[i];
			}
			delete[] apartments;
		}
		if (adress != nullptr) delete[] adress;

		char s[512];
		cout << "Адреса: ";
		cin.getline(s, 512);
		strcpy(adress = new char[strlen(s) + 1], s);

		cout << "Кiлькiсть поверхiв: ";
		cin >> kilk_floors;

		cout << "Кiлькiсть квартир: ";
		cin >> kilk_apart;

		cin.ignore();
		cout << endl;

		apartments = new Apartment* [kilk_apart];
		for (int i = 0; i < kilk_apart; ++i) {
			cout << "--------------------------------------\n";
			cout << i + 1 << " квартира.\n";
			apartments[i] = new Apartment;
			apartments[i]->input();
			cout << "--------------------------------------\n\n";
		}
	}
	inline void show() const
	{
		cout << "Адреса: " << adress << " | Поверхiв: " << kilk_floors << " | Пiд'їздiв: " << kilk_apart << endl;
		cout << "Масив квартир:\n";
		for (int i = 0; i < kilk_apart; ++i) {
			cout << i + 1 << ".\n";
			apartments[i]->show();
			cout << endl;
		}
	}
};

int main()
{
	setlocale(0, "");

	House dom;
	dom.input();
	dom.show();

	cout << endl;
	system("pause");
}