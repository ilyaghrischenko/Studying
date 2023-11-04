#include <iostream>
#include <ctime>
using namespace std;

typedef int* pointer;

pointer NewArr(int size)
{
    pointer arr = new int[size];
    for (int i = 0; i < size; ++i) {
        arr[i] = rand() % 10 - 3;
    }

    return arr;
}

void PrintArr(string name, pointer arr, int size)
{
    cout << endl << name << endl;
    for (int i = 0; i < size; ++i) {
        cout << arr[i] << "  ";
    }
    cout << endl;
}

void SortArr(pointer arr, int size)
{
    for (int i = 0; i < size - 1; ++i) {
        for (int j = i + 1; j < size; ++j) {
            if (arr[i] > arr[j]) swap(arr[i], arr[j]);
        }
    }
}

double FindMax(pointer arr, int size)
{
    SortArr(arr, size);
    double max = arr[size - 1];

    return max;
}

double FindMin(pointer arr, int size)
{
    SortArr(arr, size);
    double min = arr[0];

    return min;
}

double FindAverage(pointer arr, int size)
{
    double sum = 0, avg;
    for (int i = 0; i < size; ++i) {
        sum += arr[i];
    }
    avg = sum / size;

    return avg;
}

typedef double (*ActionFunctionPointer)(pointer, int);

void Action(pointer a, int sizeA, pointer b, int sizeB, ActionFunctionPointer function)
{
    double resultA = function(a, sizeA);
    double resultB = function(b, sizeB);
    cout << "Результат для масиву A: " << resultA << endl;
    cout << "Результат для масиву B: " << resultB << endl;
}

int main()
{
    srand((unsigned)time(NULL));
    setlocale(0, "");

    double size1, size2;
    cout << "Введіть к-сть елементів по черзі:\n";
    cin >> size1 >> size2;

    pointer arr1 = NewArr(size1);
    PrintArr("Масив А", arr1, size1);

    pointer arr2 = NewArr(size2);
    PrintArr("Масив В", arr2, size2);

    int input;
    cout << "\n\n1 - max\n2 - min\n3 - avg\n: ";
    cin >> input;

    ActionFunctionPointer User[] = { FindMax, FindMin, FindAverage };
    Action(arr1, size1, arr2, size2, User[input - 1]);

    system("pause");
    cout << endl;
    delete[] arr1;
    delete[] arr2;
}
