#pragma once
#include <iostream>
#include <ctime>
using namespace std;

#if INTEGER
#define Init InitInt
#define Show ShowInt
#define Min MinInt
#define Max MaxInt
#define Sort SortInt
#define Edit EditInt

#elif DOUBLE
#define Init InitDouble
#define Show ShowDouble
#define Min MinDouble
#define Max MaxDouble
#define Sort SortDouble
#define Edit EditDouble

#else CHAR
#define Init InitChar
#define Show ShowChar
#define Min MinChar
#define Max MaxChar
#define Sort SortChar
#define Edit EditChar
#endif

void InitChar(char*, int);
void ShowChar(char*, int);
char MinChar(char*, int);
char MaxChar(char*, int);
void SortChar(char*, int);
void EditChar(char*, int, char, int);

void InitDouble(double*, int);
void ShowDouble(double*, int);
double MinDouble(double*, int);
double MaxDouble(double*, int);
void SortDouble(double*, int);
void EditDouble(double*, int, double, int);

void InitInt(int*, int);
void ShowInt(int*, int);
int MinInt(int*, int);
int MaxInt(int*, int);
void SortInt(int*, int);
void EditInt(int*, int, int, int);