#include <iostream>
#include <ctime>
#define row 4
#define col 4
using namespace std;

//task 1
/*
void salary(double hours)
{
	int factor = 100;
	if (hours > 40) factor += 50;
	double basic_salary = 100 * hours;
	cout << "Заробiтня плата без податкiв - " << basic_salary << endl;

	double tax = 0, copy_salary = basic_salary;
	while (true) { //не зовсiм зрозумів умову задачі і як правильно розрахувати податки, сподіваюся виконав правильно.
		if (copy_salary >= 3600) {
			tax += 0.15 * 3600;
			copy_salary -= 3600;
		}
		else if (copy_salary >= 1000) {
			tax += 0.2 * 1000;
			copy_salary -= 1000;
		}
		else if (copy_salary >= 500) {
			tax += 0.2 * 500;
			copy_salary -= 500;
		}
		else {
			tax += 0.05 * copy_salary;
			break;
		}
	}
	cout << "Сума податкiв - " << tax << endl;

	cout << "Заробiтня плата з урахуванням податкiв - " << basic_salary - tax << endl;

}
*/

//task 2
/*
long perfect(int start, int end)
{
	long kilk = 0, sum_dil = 0;
	for (int i = start; i < end + 1; i++) {
		sum_dil = 0;
		for (int j = 1; j <= i / 2; j++) {
			if (i % j == 0) sum_dil += j;
		}
		if (sum_dil == i) kilk++;
	}

	return kilk;
}
*/

//task 3
/*
void card(int rank, char suit)
{
	for (int i = 0; i < 9; i++) {
		for (int j = 0; j < 6; j++) {
			if (i == 1 && j == 1) {
				cout << rank << " ";
				continue;
			}
			if (i == 1 && j == 2) {
				cout << suit << " ";
				continue;
			}
			if (i == 1 && (j > 2 && j < 5)) {
				cout << "  ";
				continue;
			}
			if ((i > 1 && i < 8) && (j > 0 && j < 5)) {
				cout << "  ";
				continue;
			}
			cout << "* ";
		}
		cout << endl;
	}
}
*/

//task 4
/*
void fctrl(int number)
{
	long fact = 1;
	for (int i = 1; i < number + 1; i++) {
		fact *= i;
	}
	cout << "Факторіал числа " << number << " = " << fact << endl;

	long copy_fact = fact, kilk = 0, sum = 0;
	while (copy_fact > 0) {
		sum += copy_fact % 10;
		copy_fact /= 10;
		kilk++;
	}
	cout << "Кількість цифр у числі " << fact << " = " << kilk << endl << "Сума всіх цифр у числі = " << sum << endl;
}
*/

//task 5
/*
int translate(int number)
{
	int copy_number = number, decimal = 0, factor = 1, last_number = 0;
	while (copy_number > 0) {
		last_number = copy_number % 10;
		decimal += last_number * factor;

		copy_number /= 10;
		factor *= 2;
	}

	return decimal;
}
*/

//task 6
/*
int indexMax(double arr[], int size)
{
	int index_max = 0, max = arr[0];
	for (int i = 0; i < size; i++) {
		if (arr[i] > max) {
			max = arr[i];
			index_max = i;
		}
	}

	return index_max;
}
*/

//task 7
/*
void print(int arr[][col])
{
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}
}

void change(int arr[][col], int first_index, int second_index)
{
	for (int i = 0; i < col; i++) {
		for (int j = 0; j < row; j++) {
			if (i == first_index) swap(arr[j][i], arr[j][second_index]);
		}
	}
}
*/

int main()
{
	srand((unsigned)time(NULL));
	setlocale(0, "");

	//task 1
	/*
	salary(10.5);
	*/

	//task 2
	/*
	int start, end;
	cout << "Введіть початок і кінець діапазону по черзі:\n";
	cin >> start >> end;

	cout << "Кількість досконалих чисел у діапазоні від " << start << " до " << end << " = " << perfect(start, end);
	*/

	//task 3
	/*
	card(4, '$'); //По факту працює, але через кодування виводить знак питання
	*/

	//task 4
	/*
	fctrl(10);
	*/

	//task 5
	/*
	cout << "Ваше число в десятковій формі = " << translate(101001001);
	*/

	//task 6
	/*
	const int size = 10;
	double arr[size];

	for (int i = 0; i < size; i++) {
		arr[i] = rand() / 1000.0 + 1.0;
	}

	for (double element : arr) {
		cout << element << "  ";
	}

	cout << "\nПорядковий номер максимального елемента в масиві = " << indexMax(arr, size) << endl;
	*/

	//task 7
	/*
	int arr[row][col]{ 0 };

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 10;
		}
	}

	cout << "Початковий масив\n";
	print(arr);

	change(arr, 0, 3);

	cout << "\nЗмінений масив\n";
	print(arr);
	*/
}