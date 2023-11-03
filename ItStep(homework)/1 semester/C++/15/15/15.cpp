#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

//task 1
/*
struct Book {
	char* name = new char[80];
	char* author = new char[80];
	char* publication = new char[80];
	char* genre = new char[80];

	void init()
	{
		cout << "Введiть назву, автора, видавництво, жанр(по черзi):\n";
		cin.getline(name, 80);
		cin.getline(author, 80);
		cin.getline(publication, 80);
		cin.getline(genre, 80);
	}
	void show()
	{
		cout << "Назва: " << name;
		cout << "\nАвтор: " << author;
		cout << "\nВидавництво: " << publication;
		cout << "\nЖанр: " << genre << endl;
	}
};

Book** NewArr(int size)
{
	Book** arr = new Book* [size];
	for (int i = 0; i < size; ++i) {
		cout << endl << i + 1 << " книга:\n";
		arr[i] = new Book;
		arr[i]->init();
	}

	return arr;
}

void PrintArr(Book** arr, int size)
{
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << ":" << endl;
		arr[i]->show();
	}
}

void DelArr(Book**& arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete[] arr[i]->name;
		delete[] arr[i]->author;
		delete[] arr[i]->publication;
		delete[] arr[i]->genre;
		delete[] arr[i];
	}
	delete[] arr;
}

void ChangeName(Book**& arr, int size, int index_book)
{
	char new_value[80];
	cout << "Введiть нове значення: ";
	cin.getline(new_value, 80);

	delete[] arr[index_book - 1]->name;

	arr[index_book - 1]->name = new char[80];
	strcpy(arr[index_book - 1]->name, new_value);
}

void ChangeAuthor(Book**& arr, int size, int index_book)
{
	char new_value[80];
	cout << "Введiть нове значення: ";
	cin.getline(new_value, 80);

	delete[] arr[index_book - 1]->author;

	arr[index_book - 1]->author = new char[80];
	strcpy(arr[index_book - 1]->author, new_value);
}

void ChangePubl(Book**& arr, int size, int index_book)
{
	char new_value[80];
	cout << "Введiть нове значення: ";
	cin.getline(new_value, 80);

	delete[] arr[index_book - 1]->publication;

	arr[index_book - 1]->publication = new char[80];
	strcpy(arr[index_book - 1]->publication, new_value);
}

void ChangeGenre(Book**& arr, int size, int index_book)
{
	char new_value[80];
	cout << "Введiть нове значення: ";
	cin.getline(new_value, 80);

	delete[] arr[index_book - 1]->genre;

	arr[index_book - 1]->genre = new char[80];
	strcpy(arr[index_book - 1]->genre, new_value);
}

void SearchAuthor(Book** arr, int size)
{
	char* search_author = new char[80] {0};
	cout << "Введiть шуканого автора: ";
	cin.getline(search_author, 80);

	bool isFind = false;
	for (int i = 0; i < size; ++i) {
		if (strcmp(arr[i]->author, search_author) == 0) {
			isFind = true;
			cout << "\nАвтор знайдений в " << i + 1 << " книзi\n";
			delete[] search_author;
			break;
		}
	}
	if (isFind == false) {
		delete[] search_author;
		cout << "\nТакого авора не iнсує!\n";
	}
}

void SearchName(Book** arr, int size)
{
	char* search_name = new char[80] {0};
	cout << "Введiть шукану назву: ";
	cin.getline(search_name, 80);

	bool isFind = false;
	for (int i = 0; i < size; ++i) {
		if (strcmp(arr[i]->name, search_name) == 0) {
			isFind = true;
			cout << "\nНазва знайдена в " << i + 1 << " книзi\n";
			delete[] search_name;
			break;
		}
	}
	if (isFind == false) {
		delete[] search_name;
		cout << "\nТакої назви не iнсує!\n";
	}
}

void Sort(Book**& arr, int size, int n)
{
	int first_sym = 0, second_sym = 0;

	for (int i = 0; i < size; ++i) {

		if (n == 1) first_sym = (int)arr[i]->name[0];
		else if (n == 2) first_sym = (int)arr[i]->publication[0];

		for (int j = i + 1; j < size; ++j) {

			if (n == 1) second_sym = (int)arr[j]->name[0];
			else if (n == 2) second_sym = (int)arr[j]->publication[0];

			if (first_sym > second_sym) swap(arr[i], arr[j]);
		}
	}
}
*/

//task 2
struct Product {
	char* name = new char[80] {NULL};
	char* manufacturer = new char[80] {NULL};
	int price = 0;

	void init()
	{
		cout << "Ім'я: ";
		cin.getline(name, 80);

		cout << "Виробник: ";
		cin.getline(manufacturer, 80);

		cout << "Ціна: ";
		cin >> price;
		cin.ignore();

		cout << endl;
	}

	void show()
	{
		cout << "Інформація: " << endl;
		cout << "Ім'я: " << name << " | Виробник: " << manufacturer << " | Ціна: " << price << "\n\n";
	}
};

Product** NewArr(int size)
{
	Product** arr = new Product* [size];
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << " товар:\n";
		arr[i] = new Product;
		arr[i]->init();
	}

	return arr;
}

void PrintArr(Product** arr, int size)
{
	cout << "СКЛАД:\n";
	for (int i = 0; i < size; ++i) {
		cout << i + 1 << ") ";
		arr[i]->show();
	}
}

void DelArr(Product**& arr, int size)
{
	for (int i = 0; i < size; ++i) {
		delete arr[i]->name;
		delete arr[i]->manufacturer;
		delete arr[i];
	}

	delete arr;
}

void AddToArr(Product**& arr, int& size)
{
	++size;

	cout << size << " товар:\n";
	arr[size - 1] = new Product;
	arr[size - 1]->init();
}

int main()
{
	setlocale(0, "");

	//task 1
	/*

	int size;
	cout << "Введiть розмiр: ";
	cin >> size;
	cin.ignore();

	Book** library = NewArr(size);
	cout << "\nМасив:\n";
	PrintArr(library, size);

	SearchAuthor(library, size);

	DelArr(library, size);
	*/

	//task 2
	int size;
	cout << "Введіть розмір: ";
	cin >> size;
	cin.ignore();

	cout << endl;

	Product** stock = NewArr(size);
	PrintArr(stock, size);

	system("pause");
	
	AddToArr(stock, size);
	PrintArr(stock, size);

	DelArr(stock, size);

	cout << endl;
	system("pause");
}