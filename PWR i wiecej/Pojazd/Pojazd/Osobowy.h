#pragma once
#include <iostream>
#include "Pojazd.h"

class Osobowy : public Pojazd
{
private:
	const double spalanieEko;    //  [l/100km]
	const double spalanieMax;    //  [l/100km]
public:
	Osobowy(double _eko, double _max, double _bak, double _start);
	bool jedz(double _dystans, bool _szybko = false);
};