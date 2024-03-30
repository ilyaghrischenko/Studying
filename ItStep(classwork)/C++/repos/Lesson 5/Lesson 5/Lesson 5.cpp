#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	setlocale(0, "");
	srand((unsigned)time(NULL));

	//task 1
	/*
	const int row = 3, col = 3;
	int arr[row][col];

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 100 + 1;
		}
	}

	cout << "\nМасив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}

	system("pause");

	int sum = 0;
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			sum += arr[i][j];
		}
	}

	int min = arr[0][0];
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] < min) min = arr[i][j];
		}
	}

	int max = arr[0][0];
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (arr[i][j] > max) max = arr[i][j];
		}
	}

	cout << "\nСума всiх елементiв масиву - " << sum << endl << "Середнє арифметичне - " << (double)sum / (row * col) << endl << "Максимальний ел. - " << max << endl << "Мiнiмальний ел. - " << min << endl;
	*/

	//task 2
	/*
	const int row = 3, col = 3;
	int arr[row][col];

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 100 + 1;
		}
	}

	cout << "\nМасив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(6);
			cout << arr[i][j];
		}
		cout << endl;
	}

	system("pause");

	int sum_all = 0;
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			sum_all += arr[i][j];
		}
	}

	cout << "\nРядки\n";
	int sum;
	for (int i = 0; i < row; i++) {
		sum = 0;
		for (int j = 0; j < col; j++) {
			sum += arr[i][j];
			cout.width(6);
			cout << arr[i][j];
		}
		cout << "| " << sum << endl;
	}

	for (int i = 0; i < 25; i++) {
		cout << '-';
	}
	cout << endl;

	for (int i = 0; i < col; i++) {
		sum = 0;
		for (int j = 0; j < row; j++) {
			sum += arr[j][i];
			//cout.width(5);
			//cout << arr[j][i];
		}
		cout.width(6);
		cout << sum;
	}
	cout << "| ";
	cout << sum_all << endl;
	*/

	//task 3
	/*const int row = 5, col = 5;
	int arr[row][col];

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			arr[i][j] = rand() % 100 + 1;
		}
	}

	cout << "\nМасив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}

	int min;
	for (int i = 0; i < row; i++) {
		min = arr[i][0];
		for (int j = 0; j < col; j++) {
			if (arr[i][j] < min) min = arr[i][j];
		}
		for (int k = 0; k < col; k++) {
			arr[i][k] -= min;
		}
	}

	cout << "\nОновлений Масив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}

	for (int i = 0; i < col; i++) {
		min = arr[0][i];
		for (int j = 0; j < row; j++) {
			if (arr[j][i] < min) min = arr[j][i];
		}
		for (int k = 0; k < row; k++) {
			arr[k][i] -= min;
		}
	}

	cout << "\nФінальний Масив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(5);
			cout << arr[i][j];
		}
		cout << endl;
	}*/

	//task 4 Додаткове (заплутався та забув сам алгоритм, щоб зробити треба посидіти)
	/*const int row = 5, col = 5;
	int arr[row][col];

	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			if (i == j) arr[i][j] = 0;
			else arr[i][j] = rand() % 100 + 1;
		}
	}

	cout << "\nМасив\n";
	for (int i = 0; i < row; i++) {
		for (int j = 0; j < col; j++) {
			cout.width(6);
			cout << arr[i][j];
		}
		cout << endl;
	}*/
}
