#include <iostream>
using namespace std;

//task 1
/*
struct Point {
	double x;
	double y;
	void init() {
		cout << "X: ";
		cin >> x;
		cout << "Y: ";
		cin >> y;
	}
	void print() {
		cout << "(" << x << ", " << y << ")\n";
	}
};

double CalcDistance(Point& a, Point& b)
{
	return sqrt(pow(a.x - b.x, 2) + pow(a.y - b.y, 2));
}
*/

//task 2
struct Fraction {
	int ch;
	int zn;
	int whole_part = 0;

	void init()
	{
		cout << "Чисельник: ";
		cin >> ch;

		cout << "Знаменник: ";
		cin >> zn;
		abbreviation();
	}
	void show()
	{
		cout << "\nДрiб:";
		if (whole_part != 0) cout << whole_part << " цiлих ";
		cout << ch << "/" << zn;
	}
	int nod(int a,int b)
	{
		if (a == b)
			return a;
		if (a >b)
			return nod(a - b, b);
		return nod(a, b - a);
	}
	void abbreviation()
	{
		int value = nod(ch, zn);
		ch /= value;
		zn /= value;
	}
	void transform()
	{
		whole_part = ch / zn;
		ch %= zn;
	}
};

Fraction sum_fr(Fraction& x, Fraction& y)
{
	Fraction new_fr;
	if (x.zn == y.zn) {
		new_fr.ch = x.ch + y.ch;
		new_fr.zn = x.zn;
	}
	else {
		new_fr.ch = x.ch * y.zn + y.ch * x.zn;
		new_fr.zn = x.zn * y.zn;
	}

	new_fr.abbreviation();
	new_fr.transform();
	return new_fr;
}

Fraction minus_fr(Fraction& x, Fraction& y)
{
	Fraction new_fr;
	if (x.zn == y.zn) {
		new_fr.ch = x.ch - y.ch;
		new_fr.zn = x.zn;
	}
	else {
		new_fr.ch = x.ch * y.zn - y.ch * x.zn;
		new_fr.zn = x.zn * y.zn;
	}
	
	new_fr.abbreviation();
	new_fr.transform();
	return new_fr;
}

Fraction dil_fr(Fraction& x, Fraction& y)
{
	Fraction new_fr;
	new_fr.ch = x.ch * y.zn;
	new_fr.zn = x.zn * y.ch;

	new_fr.abbreviation();
	new_fr.transform();
	return new_fr;
}

Fraction mnozh_fr(Fraction& x, Fraction& y)
{
	Fraction new_fr;
	new_fr.ch = x.ch * y.ch;
	new_fr.zn = x.zn * y.zn;
	
	new_fr.abbreviation();
	new_fr.transform();
	return new_fr;
}



//task 3
/*
struct Animal {
	char* name = new char[80];
	char* breed = new char[80];
	char* nickname = new char[80];
	char* voice = new char[80];

	void init()
	{
		cout << "\niм'я: ";
		cin.getline(name, 80);

		cout << "\nПорода: ";
		cin.getline(breed, 80);

		cout << "\nКличка: ";
		cin.getline(nickname, 80);

		cout << "\nГолос: ";
		cin.getline(voice, 80);
	}
	void init(char* newName, char* newBreed, char* newNickname)
	{
		name = newName;
		breed = newBreed;
		nickname = newNickname;
	}
	void show()
	{
		cout << "\niм'я: " << name;
		cout << "\nПорода: " << breed;
		cout << "\nКличка: " << nickname;
	}
	void showVoice()
	{
		cout << endl << voice << endl;
	}
};
*/

int main()
{
	setlocale(0, "");

	//task 1
	/*
	Point first{ 0.57,6./7 };

	Point second;
	second.init();

	cout << "Second:\n";
	second.print();

	cout << "vidst: " << CalcDistance(first, second) << endl;

	cout << "\nSecond point: " << "(" << second.x << ", " << second.y << ")";

	Point* p1 = new Point{ .23,6 };
	Point* p2 = new Point;

	p1->init();
	p1->print();
	
	p2->init();
	p2->print();

	cout << "vidst: " << CalcDistance(*p1, *p2) << endl;

	delete p1, p2;
	*/

	//task 2
	Fraction first;
	Fraction second;

	cout << "\nПерший дрiб:\n";
	first.init();

	cout << "\nДругий дрiб:\n";
	second.init();

	first.show();
	second.show();

	Fraction new_fr = mnozh_fr(first, second);
	new_fr.show();

	//task 3
	/*
	Animal dog;
	dog.init();
	dog.show();
	dog.showVoice();
	*/

	cout << endl;
	system("pause");
}