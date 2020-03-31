#pragma once
#include <iostream>

class Pojazd
{
protected:
	double bak;                  //  stan baku [l]
	const double pojemnoscBaku;  //  [l]
public:
	Pojazd(double _bak, double _start);
	double tankuj(double _ile);
	double stanBaku() const { return bak; }
	bool jedz(int _zuzycie);
};