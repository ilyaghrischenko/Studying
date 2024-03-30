#include <iostream>
#include <ctime>
#define row 4
#define col 4
using namespace std;

//task 1
/*
template <typename T>
T init(T arr[row][col])
{
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 10 + 1;
		}
	}

	return 0;
}

template <typename T>
T printArray(T arr[row][col])
{
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}

	return 0;
}

template <typename T>
T maxMinDiagonal(T arr[row][col])
{
	T max = arr[0][0], min = arr[0][0];
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (i == j) {
				if (arr[i][j] > max) max = arr[i][j];
				if (arr[i][j] < min) min = arr[i][j];
			}
		}
	}

	cout << "Максимальне значення на головній діагоналі: " << max << endl << "Мінімальне: " << min << endl;
	
	return 0;
}

template <typename T>
T sortRow(T arr[row][col])
{
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			for (int k = j + 1; k < col; k++) {
				if (arr[i][j] > arr[i][k]) swap(arr[i][j], arr[i][k]);
			}
		}
	}

	return 0;
}
*/

//task 2
/*
void bullsAndCows()
{
	const int size = 4;
	int pc_number[size]{ 0 }, user_number[size]{ 0 };
	int number = rand() % 9000 + 1000, input, attempts = 0, number_copy, input_copy;
	cout << "Введіть -1 у будь-якому полі вводу, щоб завершити програму\n";
	while (true) {
		cout << "Спробуйте вгадати число: ";
		cin >> input;

		if (input == -1) {
			cout << "Загадане число було - " << number;
			break;
		}

		number_copy = number, input_copy = input;
		int i = 3;
		while (number_copy > 0 && input_copy > 0) {
			pc_number[i] = number_copy % 10;
			user_number[i] = input_copy % 10;

			i--;
			number_copy /= 10;
			input_copy /= 10;
		}

		int bulls = 0, cows = 0;
		for (int i = 0; i < size; i++) {
			if (user_number[i] == pc_number[i]) {
				bulls++;
				cows++;
			}
			else {
				for (int j = 0; j < size; j++) {
					if (user_number[i] == pc_number[j]) {
						bulls++;
						break;
					}
				}
			}
		}

		cout << "\nК-ть вгаданих: " << bulls << endl << "К-ть вгаданих на своєму місці: " << cows << endl;
		system("pause");
		cout << endl;
		
		attempts++;

		if (input == number) {
			cout << "Ви вгадали число з " << attempts << " спроби!" << endl;
			break;
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
	double arr[row][col];

	init(arr);
	printArray(arr);

	cout << "\n\n";

	sortRow(arr);
	printArray(arr);

	maxMinDiagonal(arr);

	//По факту все працює, але з char не дуже виглядає, навіть не знаю як по іншому
	*/

	//task 2
	/*
	bullsAndCows();
	*/
}