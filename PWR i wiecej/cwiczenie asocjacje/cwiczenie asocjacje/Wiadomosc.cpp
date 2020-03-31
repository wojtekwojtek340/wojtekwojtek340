#include "Wiadomosc.h"
#include "Nadajnik.h"
#include <iostream>

void Wiadomosc::info()
{
	std::cout << "Wiadomosc " << ID << ". z nadajnika " <<
		zrodlo->dajID() << ":\n\"" << tresc.zawartosc() << "\"" << std::endl;
}

Wiadomosc::Wiadomosc(int _id, const char* _str, Nadajnik &_zrodlo)
{
	ID = _id;
	tresc.zawartosc = _str;
	zrodlo = &_zrodlo;
}