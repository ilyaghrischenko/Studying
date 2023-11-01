#include <iostream>
using namespace std;

int main()
{
	setlocale(0, "");
	/*
	//task 1
		/*
		int value;
		cout << "Введiть значення: ";
		cin >> value;
		if (value % 2 == 0) {
			cout << "Число " << value << " Парне";
		}
		else {
			cout << "Число " << value << " Непарне";
		}
		*/
	//task 2
			/*
			int x;
			cout << "Введiть х: ";
			cin >> x;
			x = (x % 2 == 0) ? x *= 3 : x /= 2;
			cout << x;
			*/
			//task 3
				/*
				int x, y, z, min;
				cout << "Введiть 3 числа по черзi: ";
				cin >> x >> y >> z;
				min = x;

				if (y <= x && y <= z) {
					min = y;
				}
				else if (z <= x && z <= y) {
					min = z;
				}

				cout << min << " Мiнiмальне значення";
				*/
				//task 4
		/*
		int x;
		cout << "Введiть число: ";
		cin >> x;
		if (x > 0) {
			cout << "Число бiльше 0";
		}
		else if (x < 0) {
			cout << "Число менше 0";
		}
		else {
			cout << "Число = 0";
		}
		*/
		//task 5
			/*
			int x, x1, x2, x3, x4, x5;
			int NewX;
			cout << "Введiть 5-значне число: ";
			cin >> x;
			if (x % 10000 > 1) {
				x1 = x / 10000;
				x5 = x % 10;
				x2 = x / 1000 % 10;
				x3 = x / 100 % 10;
				x4 = x / 10 % 10;
				cout << x5 << x3 << x2 << x4 << x1;
				NewX = (x5 * 10000) * (x3 * 1000) * (x2 * 100) * (x4 * 10) * x1;
			}
			else {
				cout << "Ваше число не 5-значне!";
			}
			*/
			//task 6
				/*
				int x, x1, x2, x3, x4, x5, x6;
				int NewX;
				cout << "Введiть 6-значне число: ";
				cin >> x;
				if (x % 100000 > 1) {
					x6 = x % 10;
					x /= 10;
					x5 = x % 10;
					x /= 10;
					x4 = x % 10;
					x /= 10;
					x3 = x % 10;
					x /= 10;
					x2 = x % 10;
					x /= 10;
					x1 = x;
					if ((x1 + x2 + x3) == (x4 + x5 + x6)) {
						cout << "Число щасливе";
					}
					else {
						cout << "Число не щасливе";
					}
				}
				else {
					cout << "Число не 6-значне";
				}
				*/
//task 7
/*
	cout << "Перевiр свої можливостi\n";
	system("pause");

	int grade = 0, answer;
	cout << "1 - Професор лiг спати о 8 годинi, а встав о 9 годинi. Скiльки годин проспав професор?\n";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 1) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "2 - На двох руках десять пальцiв. Скiльки пальцiв на 10?\n";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 50) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "3 - Скiльки цифр у дюжинi\n?";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 2) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "4 - Скiльки потрiбно зробити розпилiв, щоб розпиляти колоду на 12 частин?\n";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 11) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "5 - Лiкар зробив три уколи в iнтервалi 30 хвилин. скiльки часу вiн витратив?";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 30) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "6 - Скiльки цифр 9 в iнтервалi 1100?";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 1) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	cout << "7 - Пастух мав 30 овець. Усi, крiм однiєї, розбiглися. Скiльки овець лишилося?";
	cout << "Введiть вiдповiдь: ";
	cin >> answer;

	if (answer == 1) {
		cout << "Правильна вiдповiдь!\n";
		grade++;
	}
	system("pause");

	switch (grade) {
	case 3:
		cout << "Здiбностi нижче середнього";
	case 4:
		cout << "Здiбностi середнi";
	case 5:
		cout << "Нормальний";
	case 6:
		cout << "Ерудит";
	case 7:
		cout << "Генiй";
	default:
		cout << "Вам потрiбно вiдпочити";
	}
*/
//task 8
/*
	int number;
	cout << "Введіть порядковий номер пальця: ";
	cin >> number;

	switch (number) {
	case 1:
		cout << "pollex";
		break;
	case 2:
		cout << "index";
		break;
	case 3:
		cout << "medius";
		break;
	case 4:
		cout << "anularius";
		break;
	case 5:
		cout << "digitus minimus";
		break;
	default:
		cout << "Такого пальця не існує";
	}
*/
//task 9
	int a, b, c, x, y;

}