#pragma once

class Wiadomosc;

class Nadajnik
{
	int ID;

public:
	Nadajnik(int _ID);
	int dajID();
	Wiadomosc wyslij(int _idWiadomosci, const char *_str);
};