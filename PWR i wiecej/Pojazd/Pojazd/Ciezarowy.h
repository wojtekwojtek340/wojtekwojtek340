#pragma once
#include <iostream>
#include "Pojazd.h"

class Ciezarowy : public Pojazd
{
private:
	const double spalanieMin;    //  [l/100km]
	const double spalanieNaTone; //  [l/100km/tona]

public:
	Ciezarowy(double _min, double _tona, double _bak, double _start);
	bool jedz(double _dystans, double _obciazenie = 0.0);
};