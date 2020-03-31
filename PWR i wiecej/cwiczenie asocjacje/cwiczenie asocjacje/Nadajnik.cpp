#include "Nadajnik.h"
#include "Wiadomosc.h"

Nadajnik::Nadajnik(int _ID)
{
	ID = _ID;
}

int Nadajnik::dajID()
{
	return ID;
}

Wiadomosc Nadajnik::wyslij(int _idWiadomosci, const char *_str)
{
	Wiadomosc test(_idWiadomosci,_str, *this);

	return test;
}