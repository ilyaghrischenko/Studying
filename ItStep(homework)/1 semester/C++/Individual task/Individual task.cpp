#pragma warning(disable:4996)
#include <iostream>
#include <cstring>
#include <time.h>
using namespace std;

//Ўибениц€

char** ArrWords(int size)
{
    const char* words[] = { "apple", "book", "chair", "dog", "fish", "globe", "hat", "ice", "kite", "lamp",
        "moon", "note", "owl", "quilt", "shoes", "tree", "umbrella", "watch", "banana", "carrot",
        "shoes", "pencil", "snail", "robot", "zipper", "butterfly", "crown", "feather", "hamburger",
        "igloo", "juice", "magnet", "pancake", "raccoon", "velvet", "backpack", "candle", "earrings",
        "fountain", "garden", "lemon", "dice" };

    char** arr = new char* [size];
    for (int i = 0; i < size; ++i) {
        arr[i] = new char[strlen(words[i]) + 1];
        strcpy(arr[i], words[i]);
    }

    return arr;
}

void DelArr(char** arr, int size)
{
    for (int i = 0; i < size; ++i) {
        delete[] arr[i];
    }
    delete[] arr;
}

char* GetCurWord(char** arr, int size)
{
    char* cur_word = new char[80];
    for (int i = 0; i < 80; ++i) { //ERROR
        cur_word[i] = arr[rand() % size][i];
    }

    return cur_word;
}

int main()
{
    setlocale(0, "");
    srand((unsigned)time(NULL));

	int size = 42;
    char** arr_words = ArrWords(size);
    
    char* cur_word = GetCurWord(arr_words, size);
    cout << cur_word << endl;

    DelArr(arr_words, size);
    delete[] cur_word;
}