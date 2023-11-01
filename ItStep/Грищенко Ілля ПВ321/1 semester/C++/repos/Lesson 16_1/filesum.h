#pragma once

#include "typevar.h"

#ifdef INTEGER
#define Sum SumInt
#elif DOUBLE
#define Sum SumDouble
#endif

double SumDouble(double, double);
int SumInt(int, int);