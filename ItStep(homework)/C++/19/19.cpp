#include <iostream>
using namespace std;

//task 1
/*
class Fraction {
private:
	int ch;
	int zn;
public:
	Fraction()
	{
		ch = 0;
		zn = 0;
	}
	Fraction(int ch, int zn) :ch(ch), zn(zn) {}
	
	inline int GetCh() const
	{
		return ch;
	}
	inline void SetCh(int ch)
	{
		this->ch = ch;
	}

	inline int GetZn() const
	{
		return zn;
	}
	inline void SetZn(int zn)
	{
		this->zn = zn;
	}

	inline void input()
	{
		cout << "Введіть чисельник: ";
		cin >> ch;

		cout << "Введіть знаменник: ";
		cin >> zn;
	}
	inline void show() const
	{
		cout << "Дріб: " << ch << "/" << zn << endl;
	}

	friend Fraction operator+(const Fraction&, const Fraction&);
	friend Fraction operator-(const Fraction&, const Fraction&);
	friend Fraction operator*(const Fraction&, const Fraction&);
	friend Fraction operator/(const Fraction&, const Fraction&);

	friend bool operator==(const Fraction&, const Fraction&);
	friend bool operator!=(const Fraction&, const Fraction&);
	friend bool operator<(const Fraction&, const Fraction&);
	friend bool operator>(const Fraction&, const Fraction&);
};

Fraction operator+(const Fraction& x, const Fraction& y)
{
	Fraction z;
	if (x.zn == y.zn) {
		z.ch = x.ch + y.ch;
		z.zn = x.zn;
	}
	else {
		z.zn = x.zn * y.zn;
		z.ch = x.ch * y.zn + y.ch * x.zn;
	}

	return z;
}
Fraction operator-(const Fraction& x, const Fraction& y)
{
	Fraction z;

	if (x.zn == y.zn) {
		z.ch = x.ch - y.ch;
		z.zn = x.zn;
	}
	else {
		z.ch = x.ch * y.zn - y.ch * x.zn;
		z.zn = x.zn * y.zn;
	}

	return z;
}
Fraction operator*(const Fraction& x, const Fraction& y)
{
	Fraction z;

	z.ch = x.ch * y.ch;
	z.zn = x.zn * y.zn;

	return z;
}
Fraction operator/(const Fraction& x, const Fraction& y)
{
	Fraction z;

	z.ch = x.ch * y.zn;
	z.zn = x.zn * y.ch;

	return z;
}

bool operator==(const Fraction& x, const Fraction& y)
{
	if (&x == &y) return true;
	return (x.ch * y.zn == y.ch * x.zn);
}
bool operator!=(const Fraction& x, const Fraction& y)
{
	return !(x == y);
}
bool operator<(const Fraction& x, const Fraction& y)
{
	if (x != y) return (x.ch / x.zn < y.ch / y.zn);
	else return false;
}
bool operator>(const Fraction& x, const Fraction& y)
{
	if (x != y) return (x.ch / x.zn > y.ch / y.zn);
	else return false;
}
*/

//task 2
class Flat {
private:
	int kilk;
	double square;
	double price;
public:
	Flat()
	{
		kilk = 0;
		square = 0;
		price = 0;
	}
	explicit Flat(int kilk, double square, double price) :kilk(kilk), square(square), price(price) {}

	inline int GetKilk() const
	{
		return kilk;
	}
	inline void SetKilk(int kilk)
	{
		this->kilk = kilk;
	}

	inline double GetSquare() const
	{
		return square;
	}
	inline void SetSquare(double square)
	{
		this->square = square;
	}

	inline double GetPrice() const
	{
		return price;
	}
	inline void SetPrice(double price)
	{
		this->price = price;
	}

	inline void input()
	{
		cout << "Введіть к-сть: ";
		cin >> kilk;

		cout << "Введіть площу: ";
		cin >> square;

		cout << "Введіть ціну: ";
		cin >> price;
	}
	inline void show() const
	{
		cout << "К-сть: " << kilk << " | Площа: " << square << " | Ціна: " << price << endl << endl;
	}

	friend bool operator==(const Flat&, const Flat&);
	friend bool operator>(const Flat&, const Flat&);
	friend bool operator<=(const Flat&, const Flat&);
	Flat& operator++()
	{
		++kilk;
		return *this;
	}
	Flat& operator--()
	{
		--kilk;
		return *this;
	}
};

bool operator==(const Flat& x, const Flat& y)
{
	return (x.square == y.square);
}
bool operator>(const Flat& x, const Flat& y)
{
	return (x.price > y.price);
}
bool operator<=(const Flat& x, const Flat& y)
{
	return (x.price <= y.price);
}

int main()
{
	setlocale(0, "");

	Flat a(2, 3, 4);
	Flat b(3, 5, 6);
	cout << "Об'єкт а:\n";
	a.show();
	cout << "Об'єкт b:\n";
	b.show();
	system("pause");
	system("cls");

	if (a == b) cout << "Площі рівні\n";
	else cout << "Площі не рівні\n";
	system("pause");
	system("cls");

	++a;
	++b;
	cout << "Об'єкт а:\n";
	a.show();
	cout << "Об'єкт b:\n";
	b.show();
	system("pause");
	system("cls");

	if (a > b) cout << "Ціна об'єкта а > b\n";
	else cout << "Ціна b > a\n";
	system("pause");
	system("cls");

	if (a <= b) cout << "Ціна а <= b\n";
	else cout << "Ціна b > a\n";
	system("pause");
	system("cls");
	
	cout << "\nЗавершення програми...\n";
	system("pause");
}