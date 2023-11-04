#include <iostream>
using namespace std;

int main()
{
	setlocale(0, "");

	//task 1
	/*
	int grade1, grade2, grade3, grade4, grade5, average;
	cout << "Введiть 5 оцiнок студента по черзi\n";
	cin >> grade1 >> grade2 >> grade3 >> grade4 >> grade5;


	average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
	if (average >= 4) {
		cout << "Допущений";
	}
	else {
		cout << "Не допущений";
	}
	cout << "\n";
	
	system("pause");
	*/

	//task 2
	/*
	int x, x1, x2, x3, x4, NewX;
	cout << "Введiть 4-значне число: ";
	cin >> x;
	if (x >= 1000 && x <= 9999) {
		x4 = x % 10;
		x /= 10;
		x3 = x % 10;
		x /= 10;
		x2 = x % 10;
		x /= 10;
		x1 = x;
		NewX = (x2 * 1000) + (x1 * 100) + (x4 * 10) + x3;
		cout << "Нове число - " << NewX;
	}
	else {
		cout << "Число не 4-значне!";
	}
	*/

	//task 3
	/*
	int x1, x2, x3, x4, x5, x6, x7, max;
	cout << "Введiть 7 числе по черзi\n";
	cin >> x1 >> x2 >> x3 >> x4 >> x5 >> x6 >> x7;
	max = x1;
	max = (max < x2) ? max = x2 : max;
	max = (max < x3) ? max = x3 : max;
	max = (max < x4) ? max = x4 : max;
	max = (max < x5) ? max = x5 : max;
	max = (max < x6) ? max = x6 : max;
	max = (max < x7) ? max = x7 : max;

	cout << "Максимальне значення - " << max;
	*/

	//task 4
	/*
	int vidst_AB, vidst_BC, weight, emnist = 300, per_km, min_p;

    cout << "Введiть вiдстань мiж пунктами А та В: ";
    cin >> vidst_AB;

    cout << "Введiть вiдстань мiж пунктами В та С: ";
    cin >> vidst_BC;

    cout << "Введiть вагу: ";
    cin >> weight;

    if (weight < 500) {
		per_km = 1;
    }
    else if (weight < 1000) {
		per_km = 4;
    }
    else if (weight < 1500) {
        per_km = 7;
    }
    else if (weight < 2000) {
		per_km = 9;
    }
    else if (weight >= 2000) {
        cout << "Лiтак не пiднiмає" << endl;
        return 0;
    }

    
    int fuel_AB = vidst_AB * per_km;

    if (fuel_AB > emnist) {
		cout << "Неможливо подолати вiдстань мiж А та В" << endl;
        return 0;
    }

    emnist -= fuel_AB;

    int fuel_BC = vidst_BC * per_km;

    if (fuel_BC > emnist) {
        cout << "Неможливо подолати вiдстань мiж В та С" << endl;
        return 0;
    }

    min_p = fuel_AB + fuel_BC;

	cout << "Мiнiмальна кiлькiсть палива для подолання маршруту: " << min_p << endl;
	*/
	
	//task 5
	/*
	int bazh_d, k_zap, r_code, choice, tax = 0;
	cout << "1 - Введiть бажаний дохiд Васi та кiлькiсть запiзнень(по черзi)\n2 - Введiть кiлькiсть рядкiв коду, написанi Васею та бажаний обсяг зарплати\n3 - Введiть кiлькiсть рядкiв коду та кiлькiсть запiзнень\n";
	cin >> choice;

	switch (choice) {
	case 1:
		cout << "Бажаний дохiд: ";
		cin >> bazh_d;
		cout << "Кiлькiсть запiзнень: ";
		cin >> k_zap;

		tax = (k_zap >= 3) ? ((k_zap / 3) * 20) : 0;
		r_code = ((bazh_d - tax) * 100) / 50;

		cout << "Штраф: " << tax << "\nВам потрiбно написати " << r_code << " рядкiв коду, щоб заробити " << bazh_d;
		break;

	case 2:
		cout << "Кiлькiсть написаних рядкiв коду: ";
		cin >> r_code;
		cout << "Бажаний дохiд: ";
		cin >> bazh_d;

		if (r_code / 2 > bazh_d) {
			k_zap = (r_code / 2 - bazh_d) / 20;
			cout << "Кiлькiсть доступних зiпiзнень - " << k_zap;
		}
		else {
			cout << "\nВам не можна запiзнюватися!";
		}
		break;

	case 3:
		int zarp;
		cout << "Кiлькiсть рядкiв коду: ";
		cin >> r_code;
		cout << "Кiлькiсть запiзнень: ";
		cin >> k_zap;

		if (r_code / 2 > k_zap / 3 * 20) {
			zarp = (r_code / 2 - k_zap % 3 * 20);
			cout << "Ваша зарплатня - " << zarp;
		}
		else {
			cout << "Ви не отримаєте зарплату!";
		}
		break;
		
	default:
		cout << "Не доступна операцiя";
	}
	*/
}