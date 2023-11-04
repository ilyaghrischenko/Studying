#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
using namespace std;

void PrintArr(char* arr)
{
	cout << endl;
	for (int i = 0; i < strlen(arr) + 1; ++i) {
		cout << arr[i];
	}
	cout << endl;
}

//task 1
/*
void ReplaceSpaces(char* arr)
{
	for (int i = 0; i < strlen(arr); ++i) {
		if (arr[i] == ' ') arr[i] = '\t';
	}
}
*/

//task 2
/*
int CountSymbol(char* arr, char symbol)
{
	int k = 0;
	for (int i = 0; i < strlen(arr); ++i) {
		if (arr[i] == symbol) ++k;
	}

	return k;
}
*/

//task 3
/*
int KilkWords(char* arr)
{
	char* p = NULL;
	p = strtok(NULL, ":;,. ");
	int count = 0;
	do {
		p = strtok(((p == NULL) ? arr : NULL), ":;,. ");
		if (p == NULL) break;
		++count;
	} while (true);

	return count;
}

void CopyArr(char* arr1, char* arr2)
{
	for (int i = 0; i < strlen(arr1); ++i) {
		arr2[i] = arr1[i];
	}
}
*/

//task 4
/*
//strlen()
int Mystrlen(char* arr)
{
	int k = 0, i = 0;
	while (arr[i++] != '\0') {
		++k;
	}

	return k;
}
//strcat()
char* Mystrcat(char* str1, char* str2)
{
	char* new_str1 = new char[strlen(str1) + strlen(str2) + 1];
	for (int i = 0; i < strlen(str1); ++i) {
		new_str1[i] = str1[i];
	}

	for (int i = 0, j = strlen(str1); i < strlen(str2) + 1; ++i) {
		new_str1[j] = str2[i];
		++j;
	}

	return new_str1;
}

char* mystrcat(char* str1, int copacity, const char* str2) {

	int size = Mystrlen(str1) + Mystrlen(str2) + 1;
	if (size <= copacity) {
		int i = strlen(str1);
		for (auto j = 0; j <= Mystrlen(str2); ++j, ++i) {
			str1[i] = str2[j];
		}
		return str1;
	}
	char* str = new char[size];
	int i;
	for (i = 0; i < Mystrlen(str1); ++i) {
		str[i] = str1[i];
	}
	for (int j = 0; j <= Mystrlen(str2); ++j, ++i) {
		str[i] = str2[j];
	}
	//str[i] = '\0';

	return str;
}

//strchr()
char* Mystrchr(char* str, char s)
{
	//char* n;
	for (int i = 0; i < strlen(str); ++i) {
		if (str[i] == s) {
			 
			return str + i;
		}
	}

	return 0;
}
*/

//task 5
int KilkVhod(char* s, char* n)
{
	int k = 0;

	char* p = NULL;
	do {
		p = strtok(((p = NULL) ? s : NULL), ",. ;:!?");
		if (p == NULL) break;
		if (strcmp(p, n) == 0) ++k;
	} while (true);

	return k;
}

int main()
{
	/*char str[] = "d;fdfkldkfldf dfkldkl;fdl; ldfkld;";
	char a = 'a';
	char a_s[]{ 'a','\0' };// char a_s[]{"a"};
	cout << "string:\n" << str << ": " << strlen(str) << endl << a_s << endl;
	//size_t strlen(char*)

	const int n = 2;
	const int sizeStr = 80;
	char arr_str[n][sizeStr]{ "kjdklfldkfd", "kjdklfldkfd" };
	if (strcmp(arr_str[0], arr_str[1]) == 0) {
		cout << "string1==string2";
	}
	else {
		cout<<"kjkjkjk"
	}


	cout << "input string:\n";
	cin.getline(str, strlen(str) + 1);
	cout << str;
	cin.getline(str, strlen(str) + 1, 'a');
	cout << str;
	cout << "input string:\n";
	cin.getline(str, strlen(str) + 1, 'a');
	cin.ignore(1024, '\n');
	cout << str;*/

	setlocale(0, "");

	//task 1
	/*
	const int size = 80;
	char arr[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, strlen(arr) + 1);
	PrintArr(arr, size);

	cout << endl;

	ReplaceSpaces(arr);
	PrintArr(arr, size);
	*/
	
	//task 2
	/*
	const int size = 80;
	char arr[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, size);
	PrintArr(arr, size);

	char symbol;
	cout << "\nВведіть шуканий символ: ";
	cin.get(symbol);
	cin.ignore();

	int k = CountSymbol(arr, symbol);
	cout << "К-сть повторів символу: " << k;
	*/

	//task 3
	/*
	const int size = 80;
	char arr[size], copy_arr[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, size);
	PrintArr(arr);

	CopyArr(arr, copy_arr);
	PrintArr(copy_arr);

	int kilk = KilkWords(arr);
	cout << "К-сть слів в реченні: " << kilk;
	*/

	//task 4
	//strlen()
	/*
	const int size = 80;
	char arr[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, size);

	PrintArr(arr);

	int kilk = Mystrlen(arr);
	cout << "Довжина рядка: " << kilk << endl;
	*/

	//strcat()
	/*
	const int size = 80;
	char str1[size], str2[size];

	cout << "\nВведіть 1 рядок: ";
	cin.getline(str1, size);
	cout << "\nВведіть 2 рядок: ";
	cin.getline(str2, size);
	
	cout << "1 рядок";
	PrintArr(str1);
	cout << "2 рядок";
	PrintArr(str2);

	char* new_str1 = Mystrcat(str1, str2);
	PrintArr(new_str1);
	
	delete[] new_str1;
	*/

	//strchr()
	/*
	const int size = 80;
	char arr[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, size);

	PrintArr(arr);

	char s;
	cout << "Введіть шуканий символ: ";
	cin.get(s);

	char* n = Mystrchr(arr, s);
	if (n != 0) cout << "Перше входження символа " << s << " у масив " << *n;
	*/

	//task 5
	int size = 80;
	char* arr = new char[size];

	cout << "Введіть рядок: ";
	cin.getline(arr, size);
	PrintArr(arr);

	char* rev_arr = strrev(arr);
	PrintArr(rev_arr);

	cout << endl;
	system("pause");

	
}
