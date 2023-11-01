#include <iostream>
#define N 5
#define K 3
using namespace std;

//task 1
/*
struct Student {
	char surname[80];
	char group[80];
	int progress[N];

	void init()
	{
		cout << "Введіть прізвище: ";
		cin.getline(surname, 80);

		cout << "Введіть групу: ";
		cin.getline(group, 80);

		for (int i = 0; i < N; ++i) {
			cout << "Введіть " << i + 1 << " оцінку: ";
			cin >> progress[i];
			
		}
		cin.ignore();
	}
	void show()
	{
		cout << "\nПрізвище - " << surname;
		cout << "\nГрупа - " << group;
		cout << "\nУспішність:\n";
		for (int i = 0; i < N; ++i) {
			cout << progress[i] << "  ";
		}
	}
	int GoodVids()
	{
		int kilk = 0;
		for (int i = 0; i < N; ++i) {
			if (progress[i] >= 10) ++kilk;
		}

		return kilk * 100 / N;
	}
	int BadVids()
	{
		int kilk = 0;
		for (int i = 0; i < N; ++i) {
			if (progress[i] <= N) ++kilk;
		}

		return kilk * 100 / N;
	}
};

void ChangeSize(Student*& arr, int size, int new_size)
{
	Student* new_arr = new Student[new_size];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = arr[i];
	}
	for (int i = size; i < new_size; ++i) {
		cout << endl << i + 1 << " студент:\n";
		new_arr[i].init();
	}

	delete[] arr;

	arr = new_arr;
}

void PrintArr(Student* group, int size)
{
	for (int i = 0; i < size; ++i) {
		group[i].show();
		cout << endl;
	}
}

void PrintExcellent(Student* group, int size)
{
	int vids{ 0 };
	for (int i = 0; i < size; ++i) {
		
		if (group[i].GoodVids() >= 75) {
			cout << endl << group[i].surname << endl;
			vids = i;
		}
	}
	if (vids == 0) cout << "\nВідмінників немає!";
}

void PrintDv(Student* group, int size)
{
	int vids{ 0 };
	for (int i = 0; i < size; ++i) {

		if (group[i].GoodVids() >= 50) {
			cout << endl << group[i].surname << endl;
			vids = i;
		}
	}
	if (vids == 0) cout << "\nДвієчників немає!";
}
*/

//task 2
struct Man {
	char surname[80];
	char name[80];
	int age;
	int birth_date[K];

	void init()
	{
		cout << "Введіть прізвище: ";
		cin.getline(surname, 80);

		cout << "Введіть ім'я: ";
		cin.getline(name, 80);

		cout << "Введіть вік: ";
		cin >> age;
		cin.ignore();

		cout << "Введіть дату:\n";
		for (int i = 0; i < K; ++i) {
			cout << i + 1 << " число: ";
			cin >> birth_date[i];
		}
		cin.ignore();
	}
	void show()
	{
		cout << endl;
		cout << "\nПрізвище - " << surname;
		cout << "\nІм'я - " << name;
		cout << "\nВік - " << age;
		cout << "\nДата народження - " << birth_date;
	}
};

void PrintArr(Man** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		arr[i]->show();
	}
}

void PrintSurname(Man** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size - 1; ++j) {
			if ((int)arr[i]->surname[0] > (int)arr[j]->surname[0]) {
				swap(arr[i], arr[j]);
			}
		}
	}

	PrintArr(arr, size);
}

void PrintName(Man** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		for (int j = i + 1; j < size - 1; ++j) {
			if ((int)arr[i]->name[0] > (int)arr[j]->name[0]) {
				swap(arr[i], arr[j]);
			}
		}
	}

	PrintArr(arr, size);
}

void PrintBirthday(Man** arr, int size)
{
	int date;
	cout << "Введіть місяць: ";
	cin >> date;

	cout << "Іменинники:\n";
	for (int i = 0; i < size; ++i) {
		if (arr[i]->birth_date[1] == date) cout << arr[i]->surname;
	}
}

void ChangeSize(Man**& arr, int size, int new_size)
{
	Man** new_arr = new Man*[new_size];
	for (int i = 0; i < size; ++i) {
		new_arr[i] = new Man;
		new_arr[i] = arr[i];
		delete[] arr[i];
	}
	delete[] arr;

	for (int i = size; i < new_size; ++i) {
		cout << i + 1 << " людина:\n";
		new_arr[i] = new Man;
		new_arr[i]->init();
	}

	arr = new_arr;
}

int main()
{
	setlocale(0, "");

	//task 1
	/*
	int size;
	cout << "Введіть розмір масиву: ";
	cin >> size;

	Student* group = new Student[size];


	for (int i = 0; i < size; ++i) {
		cout << endl << i + 1 << " студент:\n";
		group[i].init();
	}

	for (int i = 0; i < size; ++i) {
		cout << endl;
		group[i].show();
	}

	ChangeSize(group, size, N);

	PrintExcellent(group, size);

	delete[] group;
	*/

	//task 2
	int size;
	cout << "Введіть розмір: ";
	cin >> size;
	cin.ignore();

	cout << endl;

	Man** arr = new Man* [size];
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << " людина:\n";
		arr[i] = new Man;
		arr[i]->init();
	}

	PrintArr(arr, size);

	cout << endl;
	system("pause");
}