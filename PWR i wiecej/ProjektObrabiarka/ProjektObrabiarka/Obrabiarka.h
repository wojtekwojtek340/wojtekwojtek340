#pragma once
#include <iostream>
#include "Czas.h"

class Obrabiarka
{
	Czas *czasy;
	int ileCzasow;
public:
	Obrabiarka KopiaDoCzasuSuma(const Czas _czas);
	Obrabiarka KopiaDoCzasuSuma(int _s, int _m, int _h);
	void wyswietlCzas();
	void wyswietlCzas(const int _wybranyCzas);
	void IloscCzasow();
	void dodajCzas(const Czas _czas);
	void dodajCzas(int _s = 0, int _m = 0, int _h = 0);
	void sumuj();
	Obrabiarka kopiaIlosc(const int _ile = 0);
	Obrabiarka kopiaDoCzasu(int _s, int _m = 0, int _h = 0);
	Obrabiarka kopiaDoCzasu(const Czas _czas);
	Obrabiarka& operator=(const Obrabiarka& _obrabiarka);
	Obrabiarka();
	Obrabiarka(const Obrabiarka& _inny);
	~Obrabiarka();
};