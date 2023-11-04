#pragma warning(disable:4996)
#include <iostream>
using namespace std;

class Human {
public:
	char* getName() const
	{
		if (name == nullptr) return new char[10] {"NoName"};
		return name;
	}
	void setName(char* name)
	{
		if (this->name != nullptr) delete[] this->name;
		this->name = new char[strlen(name) + 1];
		strcpy(this->name, name);
	}

	const char* getLastName() const
	{
		return lastName;
	}
	void setLastName(char* lastName)
	{
		strcpy(this->lastName, lastName);
	}

	unsigned getAge() const
	{
		return age;
	}
	void setAge(unsigned age)
	{
		this->age = age;
	}

	void show() const
	{
		cout << "Info: " << getName() << " " << lastName << " " << age << endl;
	}

private:
	char* name{ nullptr };
	char lastName[25]{ "NoName" };
	unsigned age = 0;
};

int main()
{
	Human first;
	first.show();

	char s[25]{ "" };

	cout << "Name: ";
	cin.getline(s, 25);
	first.setName(s);
	
	cout << "Last Name: ";
	cin.getline(s, 25);
	first.setLastName(s);

	first.setAge(10);

	first.show();

	cout << endl;
	system("pause");
}