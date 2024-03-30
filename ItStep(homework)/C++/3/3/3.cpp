#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    srand((unsigned)time(NULL));
    setlocale(0, "");

    //task 1
    /*
    int n;

    int r, x, y;
    while (true) {
        cout << "Оберiть фiгуру(0 - вихід, 1, 2, 3, 4, 5): ";
        cin >> n;

        if (n == 0) break;

        switch (n) {
        case 1:
            r = 9;
            x = r, y = 0;
            for (int i = 0; i < r; i++) {
                if (i <= r / 2) {
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    x -= 2;
                    y++;
                    cout << endl;
                }
                if (i >= r / 2) {
                    x += 2;
                    y--;
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
            }

            break;
        case 2:
            r = 9;
            x = 1, y = r - 2;
            for (int i = 0; i < r; i++) {
                if (i < r / 2) {
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                    x++;
                    y -= 2;
                }
                if (i == r / 2) {
                    for (int j = 0; j < r; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
                if (i > r / 2) {
                    x--;
                    y += 2;
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
            }

            break;
        case 3:
            r = 9;
            x = 1, y = r - 2;
            for (int i = 0; i < r; i++) {
                if (i < r / 2) {
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }

                    cout << endl;
                    x++;
                    y -= 2;
                }
                if (i == r / 2) {
                    for (int j = 0; j < r / 2 + 1; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
                if (i > r / 2) {
                    x--;
                    y += 2;
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    cout << endl;
                }
            }

            break;
        case 4:
            r = 9, x = 1, y = r - 1;
            for (int i = 0; i < r; i++) {
                if (i < r / 2) {

                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }

                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                    x++;
                    y--;
                }
                if (i == r / 2) {
                    for (int j = 0; j < r / 2; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < r / 2 + 1; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
                if (i > r / 2) {
                    x--;
                    y++;

                    for (int j = 0; j < y; j++) {
                        cout << "  ";
                    }
                    for (int j = 0; j < x; j++) {
                        cout << "* ";
                    }
                    cout << endl;
                }
            }

            break;
        case 5:
            x = r = 9;
            for (int i = 0; i < r; i++) {
                for (int j = 0; j < x; j++) {
                    cout << "* ";
                }
                cout << endl;
                x--;
            }

            break;
        }
    }
    */

    //task 2
    /*
    int chislo, chislo_kop, x, sum = 0, s_a = 0, k = 0, k_0 = 0;
    cout << "Введiть будь-яке цiле число: ";
    cin >> chislo;
    
    chislo_kop = chislo;

    while (chislo_kop > 0) {
        if (chislo_kop % 10 == 0) k_0++;
        x = chislo_kop % 10;
        chislo_kop /= 10;
        k++;
        sum += x;
    }
    s_a = sum / k;

    cout << "В числi " << chislo << " - " << k << " цифр" << ", з них " << k_0 << " нулiв\nСума всiх цифр числа = "<<sum<<endl<<"Середнє арифметичне = " << s_a<<endl;
    */

    //task 3
    /*
    int start = 100, end = 999, i_kop, kilk = 0, x1, x2, x3;

    for (int i = start; i <= end; i++) {
        i_kop = i;
        x3 = i_kop % 10;
        i_kop /= 10;
        x2 = i_kop % 10;
        i_kop /= 10;
        x1 = i_kop;
        if (x1 != x2 && x1 != x3 && x2 != x3) kilk++;
    }
    cout << "Кiлькiсть чисел, у дiапазонi (100-999), у яких усi цифри рiзнi = " << kilk;
    */
    
    //task 4
    /*
    int input;
    cout << "Введіть ціле число: ";
    cin >> input;

    int i = 1;
    while (i <= input) {
        if (input % i == 0) cout << i << endl;
        i++;
    }
    */

    //task 5 (додаткове)
    /*
    cout << "GUESS MY NUMBER\n";
    system("pause");

    int complexity;
    cout << "\n1 - Легкий рівень(1-10)(3 раунди)\n2 - Важкий рівень(1-100)(2 раунди)\nВаш вибір: ";
    cin >> complexity;

    int ran = 0, health = 0, pidk, input = 0, kilk_vgad = 0, end = 0, vgad_za_round;
    if (complexity == 1) {
        health = 0.5 * 10;
        end = 3;
    }
    else if (complexity == 2) {
        health = 0.25 * 91;
        end = 2;
    }

    int i = 0, UserPoints = 0, PcPoints = 0;
    while (true) {
        vgad_za_round = 0;
        if (complexity == 1) ran = rand() % 10 + 1;
        else if (complexity == 2) ran = rand() % 99 + 10;
        cout << endl << "УРОВЕНЬ " << complexity << " - РАУНД " << i + 1 << endl;
        cout << "Ваше життя - " << health << endl;
        cout << "Ваші очки - " << UserPoints << endl << "Очки комп'ютера - " << PcPoints << endl << endl;
        system("pause");

        cout << "\nВгадайте число(0 для завершення гри): ";
        cin >> input;
        if (input == 0) {
            cout << "Гру завершено!\nВаші очки - " << UserPoints << endl << "Очки комп'ютера - " << PcPoints << endl;
            break; 
        }

        if (input != ran) {
            health--;
            cout << "Ви НЕ вгадали число\n\n";
            system("pause");
            cout << "\n1 - Використати підказку\n2 - Ні\nВаш вибір(вартість підказки 1 життя): ";
            cin >> pidk;

            if (pidk == 1) {
                health--;
                if (ran > input) cout << "!Загадане число більше!\n";
                else cout << "!Загадане число менше!\n";
            }
        }
        else {
            kilk_vgad++;
            cout << "Так! Ви вгадали\n\n";
        }

        if (health == 0) break;
        
        if (kilk_vgad == 3 && complexity == 1) {
            cout << "Чи бажаєте ви перейти на складніший рівень?\n1 - Так\n2 - Ні\nВаш вибір: ";
            cin >> input;
            if (input != 1) {
                break;
            }
            complexity = 2;
        }

        if (vgad_za_round == 0 && complexity == 1) PcPoints += (0.5 * 10) * 5;
        else if (vgad_za_round == 0 && complexity == 2) PcPoints += (0.25 * 91) * 10;
        
        i++;
    }

    cout << "\n\nРезультати гри!\n";
    if (UserPoints > PcPoints) {
        cout << "Вітаю, ви перемогли!\n" << "Ваші очки - " << UserPoints << endl;
    }
    else if (PcPoints > UserPoints) {
        cout << "Ви програли!\n" << "Очки комп'ютера очки - " << PcPoints << endl;
    }
    else {
        cout << "Нічия!\n" << "Очки - " << PcPoints << endl;
    }
    */
}