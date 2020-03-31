#include<iostream>
#include "Boss.h"

using std::cin;
using std::cout;
using std::endl;

Boss::Boss(Lochy &_loch)
{
	int poziom = _loch.getPoziom();
	punktyZycia = 100 * poziom;
	obrazenia = 5 * poziom;
	doswiadczenie = 250 * poziom;
	zloto = 250 * poziom;
}

void Boss::zKimWalka()
{
	cout << "Walka z Bosem!" << endl;
}

int Boss::getPunktyZycia()
{
	return punktyZycia;
}

int Boss::getObrazenia()
{
	return obrazenia;
}

int Boss::getDoswiadczenie()
{
	return doswiadczenie;
}

int Boss::getZloto()
{
	return zloto;
}

void Boss::setPunktyZycia(const int _punktyZycia)
{
	punktyZycia = _punktyZycia;
}

void Boss::setObrazenia(const int _obrazenia)
{
	obrazenia = _obrazenia;
}

void Boss::setDoswiadczenie(const int _doswiadczenie)
{
	doswiadczenie = _doswiadczenie;
}