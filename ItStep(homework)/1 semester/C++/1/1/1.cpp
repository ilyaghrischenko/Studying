#include <iostream>
using namespace std;

int main()
{
    setlocale(0, "");
// task 1
    cout << "Завдання №1: Користувач вводить iз клавiатури час у секундах. Необхiдно написати програму, яка переведе введенi користувачем секунди в години, хвилини, секунди i виведе їх на екран.";
    int sec, min, hours;
    cout << "\n\nВведiть секунди: ";
    cin >> sec;
    hours = sec / 3600;
    min = (sec % 3600) / 60;
    sec %= 60;
    cout << "Годин: " << hours << endl << "Хвилин: " << min << endl << "Секунд: " << sec << endl;
// task 2
    cout << "\nЗавдання №2: Написати програму, яка перетворює введене з клавiатури дробове число в грошовий формат. Наприклад, число 12,5 має бути перетворено до вигляду 12 грн. 50 коп.";
    float chislo;
    cout << "\n\nВведiть число: ";
    cin >> chislo;
    int hrn = (int)chislo;
    int cop = int((chislo - hrn) * 100);
    cout << hrn << " грн. " << cop << " коп.\n";
// task 3
    cout << "\nЗавдання №3: Написати програму, що обчислює, з якою швидкiстю бiгун пробiг дистанцiю.";
    float dist, speed;
    float time;
    cout << "\n\nОбчислення швидкостi бiгу.\n";
    cout << "Введiть довжину дистнацiї (метрiв) = ";
    cin >> dist;
    cout << "Введiть час(хв.сек) = ";
    cin >> time;
    cout << "Дистанцiя: " << dist << "м.\n";
    int minutes = int(time), seconds = (time - minutes) * 100;
    speed = (dist / 1000.0) / (minutes * 60 + seconds) * 3600;
    cout << "Час: " << minutes << " хв. " << seconds << " сек." << " = " << minutes * 60 + seconds<<" cек.\n";
    cout << "Ви бiгли зi швидкiстю " << speed << " км/год.\n";
// task 4
    cout << "\nЗавдання №4: Написати програму, яка перетворює введену користувачем кількість днів на кількість повних тижнів і днів, що залишилися.";
    int input, tuzhni, dni;
    cout << "Введіть кількість днів: ";
    cin >> input;
    tuzhni = input / 7;
    dni = input - (tuzhni * 7);
    cout << tuzhni << " тижні " << dni << " дні.";
}