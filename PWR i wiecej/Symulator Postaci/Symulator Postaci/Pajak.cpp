#include<iostream>
#include "Pajak.h"

using std::cin;
using std::cout;
using std::endl;

Pajak::Pajak(Lochy &_loch)
{
	int poziom = _loch.getPoziom();
	punktyZycia = 20 * poziom;
	obrazenia = 5 * poziom;
	doswiadczenie = 10 * poziom;
	zloto = 30 * poziom;
}

void Pajak::zKimWalka()
{
	cout << "Walka z pajakiem!" << endl;
}

int Pajak::getPunktyZycia()
{
	return punktyZycia;
}

int Pajak::getObrazenia()
{
	return obrazenia;
}

int Pajak::getDoswiadczenie()
{
	return doswiadczenie;
}

int Pajak::getZloto()
{
	return zloto;
}

void Pajak::setPunktyZycia(const int _punktyZycia)
{
	punktyZycia = _punktyZycia;
}

void Pajak::setObrazenia(const int _obrazenia)
{
	obrazenia = _obrazenia;
}

void Pajak::setDoswiadczenie(const int _doswiadczenie)
{
	doswiadczenie = _doswiadczenie;
}