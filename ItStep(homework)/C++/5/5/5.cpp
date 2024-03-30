#include <iostream>
#define row 7
#define col 7
using namespace std;

//task 2
void print(int x[row][col])
{
    for (int i = 1; i < row - 1; i++) {
        for (int j = 1; j < col - 1; j++) {
            cout.width(5);
            cout << x[i][j];
        }
        cout << endl;
    }

    cout << endl;
}

void copy(int life[row][col], int copy_life[row][col])
{
    for (int i = 1; i < row; i++) {
        for (int j = 1; j < col; j++) {
            copy_life[i][j] = life[i][j];
        }
    }
}

int main()
{
    setlocale(0, "");
    srand((unsigned)time(NULL));

    //task 1
    /*
    const int row = 3, col = 3;
    long double arr[row][col];

    cout << "Введіть число: ";
    cin >> arr[0][0];
    long double x = arr[0][0];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            if (i == 0 && j == 0) continue;
            arr[i][j] = x * 2;
            x = arr[i][j];
        }
    }

    cout << "\nМасив\n";
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            cout.width(10);
            cout << arr[i][j];
        }
        cout << endl;
    }
    */

    //task 2
    /*
    int life[row][col]{ 0 }, copy_life[row][col]{ 0 };

    for (int i = 1; i < row - 1; i++) {
        for (int j = 1; j < col - 1; j++) {
            //Я оформив масив так, 1 - є життя, 0 - немає
            life[i][j] = rand() % 2;
        }
    }

    copy(life, copy_life);

    cout << "Початковий стан 'життя':\n";
    print(life);

    int years;
    cout << "Введіть кількість років: ";
    cin >> years;
    
    cout << endl;

    int kilk = 0;
    for (int step = 0; step < years; step++) {
        for (int i = 1; i < row - 1; i++) {
            for (int j = 1; j < col - 1; j++) {
                kilk = copy_life[i - 1][j - 1] + copy_life[i - 1][j] + copy_life[i - 1][j + 1] + copy_life[i][j - 1] + copy_life[i][j + 1] + copy_life[i + 1][j - 1] + copy_life[i + 1][j] + copy_life[i + 1][j + 1];
                
                if (copy_life[i][j] == 1) {
                    if (kilk == 2 || kilk == 3) copy_life[i][j] = 1;
                    else copy_life[i][j] = 0;
                }
                else {
                    if (kilk == 3) copy_life[i][j] = 1;
                }
            }
        }
        copy(copy_life, life);

        cout << step + 1 << " рік:\n";
        print(life);
        system("pause");
    }
    */
}