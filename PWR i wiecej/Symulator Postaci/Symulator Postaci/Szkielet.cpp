#include<iostream>
#include "Szkielet.h"

using std::cin;
using std::cout;
using std::endl;

Szkielet::Szkielet(Lochy &_loch)
{
	int poziom = _loch.getPoziom();
	punktyZycia = 30 * poziom;
	obrazenia = 8 * poziom;
	doswiadczenie = 20 * poziom;
	zloto = 40 * poziom;
}

void Szkielet::zKimWalka()
{
	cout << "Walka ze Szkieletem!" << endl;
}

int Szkielet::getPunktyZycia()
{
	return punktyZycia;
}

int Szkielet::getObrazenia()
{
	return obrazenia;
}

int Szkielet::getDoswiadczenie()
{
	return doswiadczenie;
}

int Szkielet::getZloto()
{
	return zloto;
}

void Szkielet::setPunktyZycia(const int _punktyZycia)
{
	punktyZycia = _punktyZycia;
}

void Szkielet::setObrazenia(const int _obrazenia)
{
	obrazenia = _obrazenia;
}

void Szkielet::setDoswiadczenie(const int _doswiadczenie)
{
	doswiadczenie = _doswiadczenie;
}