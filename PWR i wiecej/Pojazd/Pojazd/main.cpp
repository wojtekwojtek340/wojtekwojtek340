#include <iostream>
#include "Ciezarowy.h"
#include "Osobowy.h"
#include "Pojazd.h"

int main()
{
	Pojazd test1(100,50);
	Osobowy test2(10, 15, 100, 50);
	Ciezarowy test3(10, 1, 100, 50);

	std::cin.get();
	return 0;
}