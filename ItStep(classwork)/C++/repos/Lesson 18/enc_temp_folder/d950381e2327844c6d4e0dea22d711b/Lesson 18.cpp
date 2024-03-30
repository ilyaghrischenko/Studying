#include <iostream>
#include <fstream>
using namespace std;

struct Marsh {
	char name_start[80];
	char name_end[80];
	int kilk_zup;
	double avg_time;
	int number;

	void init()
	{
		cout << "Введіть назву початкового пункту: ";
		cin.getline(name_start, 80);

		cout << "Введіть назву кінцевого пункту: ";
		cin.getline(name_end, 80);

		cout << "Введіть к-сть зупинок: ";
		cin >> kilk_zup;

		cout << "Введіть середній час у дорозі: ";
		cin >> avg_time;

		cout << "Введіть номер маршруту: ";
		cin >> number;
		
		cin.ignore();
	}
	void show()
	{
		cout << "\nНомер машруту: " << avg_time << endl;
		cout << "Назва початк. пункту: " << name_start << endl;
		cout << "Назва кінц. пункту: " << name_end << endl;
		cout << "К-сть зупинок: " << kilk_zup << endl;
		cout << "Середній час у дорозі: " << avg_time << endl;
	}
};

void AddFile(char name_file[])
{
	fstream file(name_file, ios::binary | ios::app);
	
	int count;
	cout << "Введіть к-сть маршрутів: ";
	cin >> count;

	for (int i = 0; i < count; ++i) {
		Marsh a;
		a.init();
		file.write(reinterpret_cast<char*>(&a), sizeof(a));
	}

	file.close();
}

int main()
{
	setlocale(0, "");

	char name_file[]{ "first.dat" };
	AddFile(name_file);

	cout << endl;
	system("pause");
}