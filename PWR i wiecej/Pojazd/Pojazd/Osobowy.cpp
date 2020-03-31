#include "Osobowy.h"

Osobowy::Osobowy(double _eko, double _max, double _bak, double _start)
	: spalanieEko(_eko)
	, spalanieMax(_max)
	, Pojazd(_bak, _start)
{
}

bool Osobowy::jedz(double _dystans, bool _szybko) 
{
	double zuzycie;
	if (_szybko) zuzycie = _dystans * spalanieMax / 100.0;
	else zuzycie = _dystans * spalanieEko / 100.0;
	
	return jedz(zuzycie);
}