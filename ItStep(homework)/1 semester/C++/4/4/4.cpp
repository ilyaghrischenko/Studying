#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    setlocale(0, "");
    srand(time(NULL));

    //task 1
    /*
    const int n = 10;
    int arr[n];

    for (int i = 0; i < 10; i++) {
        arr[i] = rand() % 100 + 1;
    }

    cout << "\nМасив\n";
    for (int element : arr) {
        cout << element << "  ";
    }

    int sum = 0, input;
    cout << "\n\nВведiть значення, для пошуку суми: ";
    cin >> input;
    for (int element : arr) {
        if (element < input) sum += element;
    }

    cout << "Сума всiх елементiв, якi < " << input << " = " << sum;
    */

    //task 2
    /*
    const int n = 12;
    int arr[n];

    for (int i = 0; i < n; i++) {
        cout << "Введiть прибуток за " << i + 1 << " мiсяць: ";
        cin >> arr[i];
    }

    cout << "\nМасив\n";
    for (int element : arr) {
        cout << element << "  ";
    }

    int start, end;
    cout << "\n\nВведiть початок i кiнець дiапазону по черзi:\n";
    cin >> start >> end;
    if (start > end) swap(start, end);

    int max = arr[0], index_max = -1;
    for (int i = start - 1; i < end; i++) {
        if (arr[i] > max) {
            max = arr[i];
            index_max = i;
        }
    }

    int min = arr[0], index_min = -1;
    for (int i = start - 1; i < end; i++) {
        if (arr[i] < min) {
            min = arr[i];
            index_min = i;
        }
    }

    cout << "\nМiсяць у дiапазонi вiд " << start << " до " << end << "\nМаксимальний прибуток - " << index_max + 1 << " мiсяць\nМiнiмальний прибуток - " << index_min + 1 << " мiсяць";
    */

    //task 3
    /*
    const int n = 10;
    int arr[n];

    for (int i = 0; i < n; i++) {
        arr[i] = rand() % 21 - 10;
    }

    cout << "\nМасив\n";
    for (int element : arr) {
        cout << element << "  ";
    }

    int sum_neg = 0;
    for (int element : arr) {
        if (element < 0) sum_neg += element;
    }

    int min = arr[0], index_min = -1;
    for (int i = 0; i < n; i++) {
        if (arr[i] < min) {
            min = arr[i];
            index_min = i;
        }
    }

    int max = arr[0], index_max = -1;
    for (int i = 0; i < n; i++) {
        if (arr[i] > max) {
            max = arr[i];
            index_max = i;
        }
    }

    if (index_min > index_max) swap(index_min, index_max);

    int dob_min_max = 1;
    for (int i = index_min + 1; i < index_max; i++) {
        if (arr[i] != 0) dob_min_max *= arr[i];
    }

    int dob_par = 1;
    for (int element : arr) {
        if (element % 2 == 0) dob_par *= element;
    }

    int neg1 = 0, neg2 = 0;
    for (int i = 0; i < n; i++) {
        if (arr[i] < 0) {
            neg1 = i;
            break;
        }
    }

    for (int i = n - 1; i >= 0; i--) {
        if (arr[i] < 0) {
            neg2 = i;
            break;
        }
    }

    int sum_neg1_neg2 = 0;
    for (int i = neg1 + 1; i < neg2; i++) {
        sum_neg1_neg2 += arr[i];
    }

    cout << "\n\nСума негативних: " << sum_neg << endl << "Добуток ел. мiж min max: " << dob_min_max << endl << "Добуток ел. з парними номерами: " << dob_par << endl << "Сума ел. мiж 1 та останнiм нег. ел.: " << sum_neg1_neg2 << endl;
    */

    //task 4
    /*
    const int n = 10, k = 3;
    int arr[n]{ 0 }, clone_arr[n]{ 0 }, best[k]{0};

    for (int i = 0; i < n; i++) {
        cout << "Введiть " << i + 1 << " оцiнку: ";
        cin >> arr[i];
    }

    int input;
    while (true) {
        cout << "\n0 - Вихiд з програми\n1 - Вивiд оцiнок\n2 - Вивести номери 3 iспитiв з кращими оцiнками\n3 - Перездача iспиту\n4 - Перевiрити середнiй бал i можливiсть отримання стипендiї\n\n";
        cin >> input;

        if (input == 0) break;

        switch (input) {
        case 1:
            cout << "\nОцiнки\n";
            for (int element : arr) {
                cout << element << "  ";
            }

            break;
        case 2:
            for (int i = 0; i < n; i++) {
                clone_arr[i] = arr[i];
            }

            for (int i = 0; i < n - 1; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (clone_arr[i] < clone_arr[j]) {
                        swap(clone_arr[i], clone_arr[j]);
                    }
                }
            }

            for (int i = 0; i < k; i++) {
                best[i] = clone_arr[i];
            }

            for (int element : best) {
                cout << element << "  ";
            }

            break;
        case 3:
            int number, grade;
            cout << "Введiть номер iспиту, який бажаєте змiнити, а потiм оцiнку\n: ";
            cin >> number >> grade;
            arr[number - 1] = grade;

            break;
        case 4:
            float x = 0;
            for (int element : arr) {
                x += element;
            }
            x /= n;
            if (x >= 10.7) cout << "Ви вийшли на стипендiю\n";
            else cout << "Ви не вийшли на стипендiю";

            break;
        }

    }
    */

    //task 5 (Додаткове)
    /*
    const int m = 20;
    int a[m];

    for (int i = 0; i < m; i++) {
        a[i] = rand() % 100 + 1;
    }

    cout << "\nМасив\n";
    for (int element : a) {
        cout << element << "  ";
    }

    int n;
    cout << "\n\nВведіть кількість позицій, на які треба змістити масив: ";
    cin >> n;

    if (n > 0) {
        for (int i = 0; i < n; i++) {
            int copy = a[0];
            for (int j = 0; j < m - 1; j++) {
                a[j] = a[j + 1];
            }
            a[m - 1] = copy;
        }
    }

    cout << "\nЗсунутий масив\n";
    for (int element : a) {
        cout << element << "  ";
    }

    int max = a[0], index_max = 0;;
    for (int i = 0; i < m; i++) {
        if (a[i] > max) {
            max = a[i];
            index_max = i;
        }
    }

    for (int i = 0; i < index_max; i++) {
        for (int j = i + 1; j < index_max; j++) {
            if (a[i] > a[j]) swap(a[i], a[j]);
        }
    }

    for (int i = index_max + 1; i < m; i++) {
        for (int j = i + 1; j < m; j++) {
            if (a[i] < a[j]) swap(a[i], a[j]);
        }
    }

    cout << "\nРезультат\n";
    for (int element : a) {
        cout << element << "  ";
    }
    */
}