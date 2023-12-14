#pragma warning(disable:4996)
#include <iostream>
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
	Human(const char* pib, int age) :age(age)
	{
		strcpy(this->pib = new char[strlen(pib) + 1], pib);
	}
	Human(Human&& x) noexcept //чомусь мені пише щоб я додав це, не розумію чому
	{
		pib = x.pib;
		x.pib = nullptr;
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

	friend istream& operator>>(istream& s, Human& x)
	{
		x.input();
		return s;
	}
	friend ostream& operator<<(ostream& s, const Human& x)
	{
		x.show();
		return s;
	}
	Human& operator=(Human& x)
	{
		if (this != &x) {
			delete[] this->pib;
			this->pib = new char[strlen(x.pib) + 1];
			strcpy(this->pib, x.pib);

			this->age = x.age;
		}
		return *this;
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
		this->people = new Human * [kilk_peoples];
		this->people = people;
	}
	Apartment(Apartment&& x) noexcept//тут теж помилка якщо я це не додам
	{
		number = x.number;
		kilk_peoples = x.kilk_peoples;
		people = x.people;
		x.people = nullptr;
	}
	Apartment& operator=(const Apartment& x)
	{
		if (people != nullptr) {
			for (int i = 0; i < kilk_peoples; ++i) {
				delete people[i];
			}
			delete[] people;
		}
		people = new Human * [x.kilk_peoples];
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
		people = new Human * [kilk_peoples];
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
		people = new Human * [kilk_peoples];
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

	void ReplaceResident(int index, const Human& newResident)
	{
		if (index >= 0 && index < kilk_peoples) {
			people[index] = new Human;
			*people[index] = newResident;
		}
	}

	friend istream& operator>>(istream& s, Apartment& x)
	{
		x.input();
		return s;
	}
	friend ostream& operator<<(ostream& s, const Apartment& x)
	{
		x.show();
		return s;
	}
	Human* operator[](int index) const
	{
		if (index >= 0 && index << kilk_peoples) return people[index];
		else return nullptr;
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
		this->apartments = new Apartment * [kilk_apart];
		this->apartments = apartments;
	}
	House(House&& x) noexcept
	{
		adress = x.adress;
		x.adress = nullptr;
		kilk_floors = x.kilk_floors;
		kilk_apart = x.kilk_apart;
		apartments = x.apartments;
		x.apartments = nullptr;
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
		apartments = new Apartment * [x.kilk_apart];

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
		apartments = new Apartment * [kilk_apart];
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

		apartments = new Apartment * [kilk_apart];
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

	friend istream& operator>>(istream& s, House& x)
	{
		x.input();
		return s;
	}
	friend ostream& operator<<(ostream& s, const House& x)
	{
		x.show();
		return s;
	}
};

int main()
{
	setlocale(0, "");

	//task 1
	/*
	cout << "Людина:\n";
	Human a;
	cin >> a;
	cout << endl << a;

	cout << "Кваритира:\n";
	Apartment b;
	cin >> b;
	cout << endl << b;

	cout << "Будинок:\n";
	House c;
	cin >> c;
	cout << endl << c;
	*/

	//task 2
	Apartment apt;
	Human* resident = apt[0];
	cout << resident;

	system("pause");

	Human newResident;
	apt.ReplaceResident(0, newResident);
	cout << apt;

	cout << endl;
	system("pause");
}