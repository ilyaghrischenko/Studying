#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

void PrintArr(char* arr)
{
	for (int i = 0; i < strlen(arr) + 1; ++i) {
		cout << arr[i];
	}
	cout << endl << endl;
}

void DelArr(char* arr)
{
	delete[] arr;
}

//task 1
/*
int mystrcmp(char* arr1, char* arr2)
{
	if (strlen(arr1) == strlen(arr2)) return 0;
	else if (strlen(arr1) > strlen(arr2)) return 1;
	else return -1;
}

char* Upper(char* arr)
{
	for (int i = 0; i < strlen(arr); ++i) {
		arr[i] = toupper(arr[i]);
	}

	return arr;
}

char* Lower(char* arr)
{
	for (int i = 0; i < strlen(arr); ++i) {
		arr[i] = tolower(arr[i]);
	}

	return arr;
}

char* mystrrev(char* arr, int size)
{
	int start = 0, end = strlen(arr) - 1;

	while (start < end) {
		char temp = arr[start];
		arr[start] = arr[end];
		arr[end] = temp;

		++start;
		--end;
	}
	arr[strlen(arr)] = '\0';

	return arr;
}
*/

//task 2.1
/*
void ReplaceWord(char*& arr, char* search_word, char* replace)
{
	for (int i = 0; i <= strlen(arr) - strlen(search_word); ++i) {
		bool match = true;
		for (int j = 0; j < strlen(search_word); ++j) {
			if (arr[i + j] != search_word[j]) {
				match = false;
				break;
			}
		}
		if (match) {
			for (int j = i; j < i + strlen(replace); ++j) {
				arr[j] = replace[j - i];
			}
			i += strlen(replace) - 1;
		}
	}
}
*/

//task 2.2
/*
void UpperSentences(char*& arr)
{
	char symbols[]{ '.','?','!' };
	bool new_sentence = true;
	for (int i = 0; i < strlen(arr); ++i) {
		if (new_sentence && isalpha(arr[i])) {
			arr[i] = toupper(arr[i]);
			new_sentence = false;
		}
		else {
			for (int j = 0; j < 3; ++j) {
				if (arr[i] == symbols[j]) new_sentence = true;
			}
		}
	}
}
*/

//task 2.3
/*
void PrintPovt(char* arr)
{

	char* sym = new char[80];
	int kilk = 0;

	for (int i = 0, k = 0; i < strlen(arr); ++i) {
		bool isSame = false;
		for (int j = 0; j < kilk; ++j) {
			if (arr[i] == sym[j]) {
				isSame = true;
				break;
			}
		}
		if (!isSame) {
			sym[k] = arr[i];
			++k;
			++kilk;
		}
	}

	for (int i = 0; i < kilk; ++i) {
		char symbol = sym[i];
		int count = 0;
		for (int j = 0; j < strlen(arr); ++j) {
			if (symbol == arr[j]) ++count;
		}
		cout << "'" << symbol << "' " << count << " раз" << " " << endl;
	}

	delete[] sym;
}
*/

//task 2.4
/*
void PrintKilkNumbers(char* arr)
{
	int kilk = 0;
	for (int i = 0; i < strlen(arr); ++i) {
		if (isdigit(arr[i])) ++kilk;
	}

	cout << "Кількість цифр: " << kilk << endl;
}
*/

int main()
{
	setlocale(0, "");

	//task 1
	/*
	int size = 80;
	char* arr1 = new char[size];
	char* arr2 = new char[size];

	cout << "Введiть 1 рядок: ";
	cin.getline(arr1, size);
	PrintArr(arr1);

	cout << "Введiть 2 рядок: ";
	cin.getline(arr2, size);
	PrintArr(arr2);

	cout << "\nФункцiя uppercase(1 масив):\n";
	arr1 = Upper(arr1);
	PrintArr(arr1);

	cout << "\nФункцiя lowercase(2 масив):\n";
	arr2 = Lower(arr2);
	PrintArr(arr2);

	int rezult = mystrcmp(arr1, arr2);
	cout << "\nrezult: " << rezult << endl;

	arr1 = mystrrev(arr1, size);
	cout << "Перевернутий масив:\n";
	PrintArr(arr1);

	delete[] arr1, arr2;
	*/

	//task 2
	int size = 80;
	char* arr = new char[size];
	
	cout << "Введiть рядок: ";
	cin.getline(arr, size);
	
	cout << "\nМасив:\n";
	PrintArr(arr);

	//task 2.1
	/*
	char* search_word = new char[size];
	cout << "Введiть шукане слово: ";
	cin.getline(search_word, size);

	char* replace = new char[size];
	cout << "Введiть слово, на яке бажаєте замiнити: ";
	cin.getline(replace, size);


	cout << "Шукане слово:\n";
	PrintArr(search_word);
	
	cout << "Замiна:\n";
	PrintArr(replace);

	ReplaceWord(arr, search_word, replace);

	cout << "Масив:\n";
	PrintArr(arr);

	DelArr(arr);
	DelArr(search_word);
	DelArr(replace);
	*/

	//task 2.2
	/*
	UpperSentences(arr);
	cout << "\nМасив:\n";
	PrintArr(arr);

	DelArr(arr);
	*/

	//task 2.3
	/*
	PrintPovt(arr);
	*/

	//task 2.4
	/*
	PrintKilkNumbers(arr);
	*/

	DelArr(arr);

	cout << endl;
	system("pause");

}