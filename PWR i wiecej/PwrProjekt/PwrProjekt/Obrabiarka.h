#pragma once
#include <iostream>
#include "Czas.h"

class Obrabiarka
{
	Czas *czasy;
	int ileCzasow;
public:
	void wyswietlCzas();
	void wyswietlCzas(const int _wybranyCzas);
	void dodajCzas(const Czas _czas);
	void dodajCzas(int _s = 0, int _m = 0,int _h = 0);
	void sumuj();
	Obrabiarka& operator=(const Obrabiarka& _obrabiarka);
	Obrabiarka();
	Obrabiarka(const Obrabiarka& _inny);
	~Obrabiarka();
};