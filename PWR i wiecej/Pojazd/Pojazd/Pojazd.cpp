#include "Pojazd.h"


Pojazd::Pojazd(double _bak, double _start)
	: pojemnoscBaku(_bak)
{
	if (_start < pojemnoscBaku) {
		bak = _start;
	}
	else {
		bak = pojemnoscBaku;
	}
	if (_start <= 0) {
		bak = 0;
	}
	else {
		bak = _start;
	}
}

double Pojazd::tankuj(double _ile)
{
	double daSieNalac = pojemnoscBaku - bak;
	if (_ile > daSieNalac) {
		bak = pojemnoscBaku;
		return daSieNalac;
	}
	else {
		bak += _ile;
		return _ile;
	}
}

bool Pojazd::jedz(int _zuzycie)
{

	if (_zuzycie > bak) {
		std::cout << "Za malo paliwa by przejechac odcinek!"
			<< " Potrzeba " << _zuzycie << "l, dostepne " << bak << "l." << std::endl;
		return false;
	}
	else {
		std::cout << "Zuzyto " << _zuzycie << " l paliwa." << std::endl;
		bak -= _zuzycie;
		return true;
	}
}