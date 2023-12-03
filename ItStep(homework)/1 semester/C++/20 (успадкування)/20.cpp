#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

//task 1
/*
class Pet {
protected:
	string name;
	int age;
	bool is_train;
public:
	Pet() :name("NoName"), age(0), is_train(false) {}
	Pet(string name, int age, bool is_train) :name(name), age(age), is_train(is_train) {}

	inline string GetName() const
	{
		return name;
	}
	inline void SetName(string name)
	{
		this->name = name;
	}

	inline int GetAge() const
	{
		return age;
	}
	inline void SetAge(int age)
	{
		this->age = age;
	}

	inline bool GetIsTrain() const
	{
		return is_train;
	}
	inline void SetIsTrain(bool is_train)
	{
		this->is_train = is_train;
	}

	inline void input()
	{
		cout << "iм'я: ";
		cin >> name;

		cout << "Вiк: ";
		cin >> age;

		cout << "Тренований?: ";
		cin >> is_train;
	}
	inline void show() const
	{
		cout << "iм'я: " << name << " | Вiк: " << age << " | Тренований?: " << is_train << endl;
	}
};

class Dog :public Pet {
private:
	string fav_toy;
public:
	Dog() :fav_toy("NoFavToy") {}
	Dog(string name, int age, bool is_train, string fav_toy) :Pet(name, age, is_train), fav_toy(fav_toy) {}

	inline string GetFavToy() const
	{
		return fav_toy;
	}
	inline void SetFavToy(string fav_toy)
	{
		this->fav_toy = fav_toy;
	}

	inline void input()
	{
		Pet::input();

		cout << "Улюблена iграшка: ";
		cin >> fav_toy;
	}
	inline void show() const
	{
		cout << "Собака:\n";

		Pet::show();
		cout << "Улюблена iграшка: " << fav_toy << endl;
	}
};

class Cat :public Pet {
private:
	string fav_korm;
public:
	Cat() :fav_korm("NoFavKorm") {}
	Cat(string name, int age, bool is_train, string fav_korm) :Pet(name, age, is_train), fav_korm(fav_korm) {}

	inline string GetFavKorm() const
	{
		return fav_korm;
	}
	inline void SetFavKorm(string fav_korm)
	{
		this->fav_korm = fav_korm;
	}

	inline void input()
	{
		Pet::input();

		cout << "Улюблений корм: ";
		cin >> fav_korm;
	}
	inline void show() const
	{
		cout << "Кiт:\n";

		Pet::show();
		cout << "Улюблений корм: " << fav_korm << endl;
	}
};

class Parrot :public Pet {
private:
	string breed;
public:
	Parrot() :breed("NoBreed") {}
	Parrot(string name, int age, bool is_train, string breed) :Pet(name, age, is_train), breed(breed) {}

	inline string GetBreed() const
	{
		return breed;
	}
	inline void SetBreed(string breed)
	{
		this->breed = breed;
	}

	inline void input()
	{
		Pet::input();

		cout << "Порода: ";
		cin >> breed;
	}
	inline void show() const
	{
		cout << "Папуга:\n";
		
		Pet::show();
		cout << "Порода: " << breed << endl;
	}
};
*/

//task 2
class String {
protected:
	char* data;
	int length;

public:
	String() : data(nullptr), length(0) {}
	String(const char* str)
	{
		length = strlen(str);
		data = new char[length + 1];
		strcpy(data, str);
	}
	String(const String& x)
	{
		length = x.length;
		data = new char[length + 1];
		strcpy(data, x.data);
	}
	String& operator=(const String& x)
	{
		if (this != &x) {
			delete[] data;
			length = x.length;
			data = new char[length + 1];
			strcpy(data, x.data);
		}
		return *this;
	}
	~String()
	{
		clear();
	}

	inline int GetLength() const
	{
		return length;
	}
	inline void clear()
	{
		delete[] data;
		data = nullptr;
		length = 0;
	}

	String operator+(const String& x) const
	{
		String result;
		result.length = length + x.length;
		result.data = new char[result.length + 1];
		strcpy(result.data, data);
		strcat(result.data, x.data);

		return result;
	}
	String& operator+=(const String& x)
	{
		*this += x;
		return *this;
	}

	inline bool operator==(const String& x) const
	{
		return (length == x.length) && (strcmp(data, x.data) == 0);
	}
	inline bool operator!=(const String& x) const
	{
		return !(*this == x);
	}
};

class BinaryString : public String {
public:
	BinaryString() : String() {}
	BinaryString(const char* str)
	{
		length = strlen(str);
		data = new char[length + 1];
		bool isValid = true;

		for (int i = 0; i < length; ++i) {
			if (str[i] != '0' && str[i] != '1') {
				isValid = false;
				break;
			}
		}

		if (isValid) {
			strcpy(data, str);
		}
		else {
			clear();
		}
	}
	BinaryString(const BinaryString& x) : String(x) {}
	BinaryString& operator=(const BinaryString& x)
	{
		if (this != &x) {
			String::operator=(x);
		}
		return *this;
	}

	inline void changeSign()
	{
		data[0] = (data[0] == '+') ? '-' : '+';
	}

	BinaryString operator+(const BinaryString& x) const
	{
		BinaryString result;
		result.length = length + x.length;
		result.data = new char[result.length + 1];
		strcpy(result.data, data);
		strcat(result.data, x.data);

		return result;
	}
	BinaryString& operator+=(const BinaryString& x)
	{
		*this += x;
		return *this;
	}
	inline bool operator==(const BinaryString& x) const
	{
		if (&*this == &x) return true;
		
		return (this->data == x.data && this->length == length) ? true : false;
	}
	inline bool operator!=(const BinaryString& x) const
	{
		return !(*this == x);
	}
};

int main()
{
	setlocale(0, "");

	//task 1
	/*
	Dog x("rey", 2, true, "ring");
	Cat y("pusha", 12, true, "whiskas");
	Parrot z("name", 4, true, "breed");

	x.show();
	cout << endl;
	y.show();
	cout << endl;
	z.show();
	*/

	cout << endl;
	system("pause");
}