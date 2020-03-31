#include <iostream>
#include "Wiadomosc.h"
#include "Nadajnik.h"
#include "String.h"

int main()
{
	Nadajnik N1(1001), N2(1002);
	N1.wyslij(1, "UWIELBIAM").info();
	N1.wyslij(2, "C++").info();
	Wiadomosc w3 = N2.wyslij(1, "PS. to prawda");
	w3.info();
	std::cin.get();
}