#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	//srand((unsigned)time(NULL));
	setlocale(0, "");
	//task 1
	/*
	int start, end, number;
	cout << "Введiть 2 межi дiапазону по черзi(start, end): ";
	cin >> start >> end;
	if (end < start) {
		swap(start, end);
	}
	do {
		cout << "Введiть число в межах (" << start << ", " << end << "): ";
		cin >> number;
		if (number >= start && number <= end) {
			cout << "Вiрно введене число";
			break;
		}
		cout << "Число введено не вiрно";
	} while (number<start || number>end);
	*/

	//task 2
	/*
	int answer, number1, number2, n, level;
	cout << "1 - Легкий рiвень(3 питання)\n2 - Середнiй рiвень(5 питань)\n3 - Високий рiвень(7 питань)\nВаш вибiр: ";
	cin >> n;
	switch (n) {
	case 1:
		cout << "\nЛегкий рiвень\n\n";
		level = 3;
		break;
	case 2:
		cout << "\nСереднiй рiвень\n\n";
		level = 5;
		break;
	case 3:
		cout << "\nВисокий рiвень\n\n";
		level = 7;
		break;
	}
	int grade = 0;
	for (int i = 0; i < level; i++) {
		number1 = rand() % 10 + 1;
		number2 = rand() % 10 + 1;
		cout << number1 << " * " << number2 << " = ";
		cin >> answer;
		if (answer != number1 * number2) {
			cout << "Не правильна вiдповiдь!\n\n";
			system("pause");
			continue;
		}
		cout << "Вiдповiдь правильна\n\n";
		system("pause");
		grade++;
	}
	cout << "\nВи вiдповiли правильно на " << grade << " з 3 питань\n";
	*/

	//task 3
	/*
	int chislo, NewChislo = 0;
	cout << "Введiть будь-яке цiле число: ";
	cin >> chislo;
	
	int chislo_kop = chislo;

	int roz = 1;
	while (chislo_kop > 0) {
		if (chislo_kop % 10 == 3 || chislo_kop % 10 == 6) {
			chislo_kop /= 10;
			continue;
		}
		NewChislo += roz * (chislo_kop % 10);
		chislo_kop /= 10;
		roz *= 10;
	}
	cout << NewChislo;
	*/

	//task 4
	/*
	int start, end;
	cout << "Введiть межi дiапазону по черзi (початок, кiнець): ";
	cin >> start >> end;
	if (start > end) swap(start, end);

	int sum = 0;
	for (int i = start; i <= end; i++) {
		sum += i;
	}

	cout << "Сума всiх чисел в дiапазонi (" << start << " - " << end << ") = " << sum << endl;
	system("pause");
	*/

	//task 5
	/*
	int input = 0, sum = 0;

	cout << "Введіть число: ";
	cin >> input;
	while (input != 0) {
		sum += input;
		cin >> input;
	}

	cout << "Сума всіх чисел - " << sum << endl;
	system("pause");
	*/

	//task 6
	/*
	int kilk, price, discountб, n;
	
	cout << "1 - Ялинка\n2 - Іграшка на ялинку\n3 - Дощик\nВаш вибір: ";
	cin >> n;

	switch (n) {
	case 1:
		cout << "Введіть кількість: ";
		cin >> kilk;
		break;
	}
	*/
}