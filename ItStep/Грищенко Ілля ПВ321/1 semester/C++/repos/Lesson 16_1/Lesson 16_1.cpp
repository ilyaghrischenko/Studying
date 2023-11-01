#define INTEGER 0
#define DOUBLE 1
#define CHAR 0
#include "Function.h"

int main()
{
	int N = 10;
	#if INTEGER
		#define TP int
	#elif DOUBLE
		#define TP double
	#else
		#define TP char
	#endif

	TP* arr = new TP[N];
	Init(arr, N);
	Show(arr, N);
	
	cout << endl;
	system("pause");
}