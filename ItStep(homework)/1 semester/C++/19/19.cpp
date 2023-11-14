#include <iostream>
using namespace std;

//task 1
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
		cout << "¬вед≥ть чисельник: ";
		cin >> ch;

		cout << "¬вед≥ть знаменник: ";
		cin >> zn;
	}
	inline void show() const
	{
		cout << "ƒр≥б: " << ch << "/" << zn << endl;
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
		cout << "¬вед≥ть к-сть: ";
		cin >> kilk;

		cout << "¬вед≥ть площу: ";
		cin >> square;

		cout << "¬вед≥ть ц≥ну: ";
		cin >> price;
	}
	inline void show() const
	{
		cout << " -сть: " << kilk << " | ѕлоща: " << square << " | ÷≥на: " << price << endl << endl;
	}
};

int main()
{
	setlocale(0, "");



	cout << endl;
	system("pause");
}