#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
#define N 512
using namespace std;

class Reservoir {
private:
	char name[N];
	char type[N];
	double width;
	double lenght;
	double max_depth;
public:
	Reservoir()
	{
		strcpy(name, "No name");
		strcpy(type, "No type");
		width = 0;
		lenght = 0;
		max_depth = 0;
	}
	Reservoir(const char* name, const char* type) :Reservoir()
	{
		strcpy(this->name, name);
		strcpy(this->type, type);
	}
	Reservoir(double width, double lenght, double max_depth) :Reservoir()
	{
		this->width = width;
		this->lenght = lenght;
		this->max_depth = max_depth;
	}
	explicit Reservoir(const char* name,const char* type, double width, double lenght, double max_depth) :width(width), lenght(lenght), max_depth(max_depth)
	{
		strcpy(this->name, name);
		strcpy(this->type, type);
	}

	inline const char* GetName() const {
		return name;
	}
	inline void SetName(const char* name)
	{
		strcpy(this->name, name);
	}

	inline const char* GetType() const
	{
		return type;
	}
	inline void SetType(const char* type)
	{
		strcpy(this->type, type);
	}

	inline double GetWidth() const
	{
		return width;
	}
	inline void SetWidth(double width)
	{
		this->width = width;
	}

	inline double GetLenght() const
	{
		return lenght;
	}
	inline void SetLenght(double lenght)
	{
		this->lenght = lenght;
	}

	inline double GetMaxDepth() const
	{
		return max_depth;
	}
	inline void SetMaxDepth(double max_depth)
	{
		this->max_depth = max_depth;
	}

	inline void input()
	{
		cout << "Ім'я: ";
		cin.getline(name, N);

		cout << "Тип: ";
		cin.getline(type, N);

		cout << "Ширина: ";
		cin >> width;

		cout << "Довжина: ";
		cin >> lenght;

		cout << "Макс. глибина: ";
		cin >> max_depth;

		cin.ignore();
	}
	inline void show() const
	{
		cout << "Ім'я: " << name << " | Тип: " << type << " | Ширина: " << width << " | Довжина: " << lenght << " | Макс. глубина: " << max_depth << endl;
	}

	//1
	inline double CalcVolume() const
	{
		return width * lenght * max_depth;
	}
	//2
	inline double CalcSquare() const
	{
		return width * lenght;
	}
};	

//3
bool CheckType(const Reservoir& x, const Reservoir& y)
{
	return (strcmp(x.GetType(), y.GetType()) == 0) ? true : false;
}

//4
void CheckSquare(const Reservoir& x, const Reservoir& y)
{
	if (CheckType(x, y)) {
		if (x.CalcSquare() > y.CalcSquare()) cout << "1>2\n";
		else cout << "2>1\n";
	}
	else cout << "Водойми мають різний тип\n";
}

int main()
{
	setlocale(0, "");

	//1
	Reservoir a("reservoir1", "type1", 13, 11, 10);
	a.show();
	cout << "Приблизний обсяг = " << a.CalcVolume() << endl;
	//2
	cout << "Площа водної поверхні = " << a.CalcSquare() << endl;
	system("pause");
	system("cls");
	//3
	Reservoir b("res", "type1", 34, 9, 2);
	if (CheckType(a, b)) cout << "Належать до одного типу\n\n";
	else cout << "Не належать до одного типу\n\n";
	system("pause");
	system("cls");
	//4
	CheckSquare(a, b);
	system("pause");
	system("cls");
	//5
	//наскільки я пам'ятаю, копіювання нема сенсу робити для классу без покажчиків

	cout << endl;
	system("pause");
}