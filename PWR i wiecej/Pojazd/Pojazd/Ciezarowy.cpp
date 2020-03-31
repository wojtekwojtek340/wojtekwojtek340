#include "Ciezarowy.h"

Ciezarowy::Ciezarowy(double _min, double _tona, double _bak, double _start)
	: spalanieMin(_min)
	, spalanieNaTone(_tona)
	, Pojazd(_bak, _start)
{
}

bool Ciezarowy::jedz(double _dystans, double _obciazenie) 
{
	double spalanie = spalanieMin + spalanieNaTone * _obciazenie;
	double zuzycie = _dystans * spalanie / 100.0;
	
	return jedz(zuzycie);
}