#include <iostream>
#include <string>
#include <vector>
#include <map>
#include <fstream>
#include <ctime>
using namespace std;

typedef map<string, vector<int>> dictionary;
typedef vector<int> arr;

class User {
protected:
	bool isRegistered;
	string login;
	string password;
	int encryption_key;

	void CheckIsRight(string& text)
	{
		bool isAccepted = false;
		while (!isAccepted) {
			cin >> text;
			int kilk_upper = 0;
			int kilk_numbers = 0;
			for (int i = 0; i < text.length(); ++i) {
				if (text[i] == toupper(text[i])) ++kilk_upper;
				if (text[i] == isdigit(text[i])) ++kilk_numbers;
			}
			if (kilk_upper >= 1 && kilk_numbers >= 3) isAccepted = true;
			else cout << "Помилка при введенні!\nВведіть повторно: ";
		}
	}
	void EncryptText(string& text)
	{
		for (int i = 0; i < text.length(); ++i) {
			text[i] += encryption_key;
		}
	}
	void Registration()
	{
		cout << "Реєстрація користувача:\n1)Ваш логін і пароль повинен містити хоча б 1 велику літеру.\n2)Ваш логін і пароль повинен містити хоча б 3 цифри.\n\n";

		cout << "Логін: ";
		CheckIsRight(login);

		cout << "Пароль: ";
		CheckIsRight(password);

		isRegistered = true;

		EncryptText(login);
		EncryptText(password);
	}
public:
	User() :isRegistered(false), login("NoLogin"), password("NoPassword"), encryption_key(3) {}
};

class Guest :public User {
private:
	string pib;
	string address;
	string phone_number;
	dictionary grades;
public:
	Guest() :pib("NoPib"), address("NoAddress"), phone_number("NoPhoneNumber")
	{
		grades = { {"Математика",{0}},{"Англійська мова",{0}},{"Географія",{0}} };
	}
	Guest(const string& pib, const string& address, const string& phone_number, const dictionary&& arr) : pib(pib), address(address), phone_number(phone_number), grades(arr) {}

	inline bool GetIsRegistered() const
	{
		return isRegistered;
	}

	inline string GetPib() const
	{
		return pib;
	}
	inline void SetPib(const string& pib)
	{
		this->pib = pib;
	}

	inline string GetAddress() const
	{
		return address;
	}
	inline void SetAddress(const string& address)
	{
		this->address = address;
	}

	inline string GetPhoneNumber() const
	{
		return phone_number;
	}
	inline void SetPhoneNumber(const string& phone_number)
	{
		this->phone_number = phone_number;
	}

	inline dictionary GetGrades() const
	{
		return grades;
	}

	inline void input()
	{
		cout << "ПІБ: ";
		getline(cin, pib);

		cout << "Адреса: ";
		getline(cin, address);

		cout << "Номер телефону: ";
		getline(cin, phone_number);
	}
	void show() const
	{
		cout << "ПІБ: " << pib << " | Адреса: " << address << " | Номер телефону: " << phone_number << "\nОцінки:\n";

		for (auto i : grades) {
			cout << i.first << ": ";
			for (int j : i.second) {
				cout << j << ", ";
			}
			cout << endl;
		}

		cout << endl;
	}

	void MathTest()
	{
		cout << "Тест з математики(максимальний бал - 12):\n";
		
		arr tasks{ rand() % 10 + 1,rand() % 10 - 3 };
	}
};

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));
	


	cout << endl;
	system("pause");
}