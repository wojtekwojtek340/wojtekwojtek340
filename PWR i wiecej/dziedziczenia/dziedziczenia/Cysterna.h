#pragma once
#include "Cylinder.h"

class Cysterna : public Cylinder
{
	double gestoscCieczy;
	double poziomNapelnienia;

public:

	Cysterna(double _pr, double _wy);
	bool czyPelna();
	double obliczObjetosc();
	double obliczMase();
	void ustawPoziom(double _ilosc);

};
