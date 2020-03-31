#include<iostream>
#include "Gracz.h"
#include "Bron.h"
#include <fstream>
#include "Menu.h"
#include <iomanip> 
#include <sstream>

using std::cin;
using std::cout;
using std::endl;

Gracz::Gracz()
	:punktyZycia(150)
	,maxPunktyZycia(150)
	,sila(10)
	,zrecznosc(10)
	,poziom(1)
	,doswiadczenie(0)
	,zloto(0)
	,bron(nullptr)
{}

void Gracz::dodajDoswiadczenie(int _doswiadczenie)
{
	doswiadczenie += _doswiadczenie;
	while (doswiadczenie >= poziom * 100)
	{
		doswiadczenie -= poziom * 100;
		awans();
	}
}

void Gracz::dodajZloto(const int _zloto)
{
	zloto += _zloto;
}

void Gracz::awans()
{
	poziom++;
	maxPunktyZycia += 50;
	punktyZycia = maxPunktyZycia;
	sila += 5;
	zrecznosc += 5;
	zloto += 100;
}

void Gracz::ustawBron(Bron *_bron)
{
	bron = _bron;
}

void Gracz::wypiszStatystyki()
{
	cout << "Poziom: " << getPoziom() << endl;
	cout << "Doswiadczenie: " << getDoswiadczenie() << "/" << getPoziom() * 100 << endl;
	cout << "Zloto: " << getZloto() << endl << endl;
	cout << "PunktyZycia: " << getPunktyZycia() << "/" << maxPunktyZycia << endl;
	cout << "Sila: " << getSila() << endl;
	cout << "Zrecznosc: " << getZrecznosc() << endl << endl << endl;
	try
	{
		cout << "Nazwa broni: " << getBronNazwa() << endl;
		cout << "Obrazenia broni: " << getBronObrazenia() << endl << endl << endl;
	}
	catch (std::exception &blad)
	{
		cout << "Bron: " << blad.what() << endl << endl << endl;
	}
}

int Gracz::getPunktyZycia()
{
	return punktyZycia;
}

int Gracz::getSila()
{
	return sila;
}

int Gracz::getZrecznosc()
{
	return zrecznosc;
}

int Gracz::getPoziom()
{
	return poziom;
}

int Gracz::getDoswiadczenie()
{
	return doswiadczenie;
}

int Gracz::getZloto()
{
	return zloto;
}

string Gracz::getBronNazwa()
{
	if (bron != nullptr)
	{
		return bron->getNazwa();
	}
	else
	{
		throw std::exception("Brak broni!");
	}
}

int Gracz::getBronObrazenia()
{
	if (bron != nullptr)
	{
		return bron->getObrazenia();
	}
	else
	{
		throw std::exception("Brak broni!");
	}
}

void Gracz::setPunktyZycia(const int _punktyZycia)
{
	punktyZycia = _punktyZycia;
}

void Gracz::setSila(const int _sila)
{
	sila = _sila;
}

void Gracz::setZrecznosc(const int _zrecznosc)
{
	zrecznosc = _zrecznosc;
}

void Gracz::setPoziom(const int _poziom)
{
	poziom = _poziom;
}

void Gracz::setDoswiadczenie(const int _doswiadczenie)
{
	doswiadczenie = _doswiadczenie;
}

void Gracz::setZloto(const int _zloto)
{
	zloto = _zloto;
}

void Gracz::pokazEkwipunek()
{
	for (int i = 0; i < ekwipunek.size(); i++)
	{
		cout << i + 1 << ". " << ekwipunek.at(i)->getNazwa();
		int dlugosc = strlen(ekwipunek.at(i)->getNazwa().c_str());
		cout.width(50 - dlugosc);
		cout << "Obrazenia -> " << ekwipunek.at(i)->getObrazenia();
		int a = ekwipunek.at(i)->getObrazenia();
		std::stringstream b;
		b << a;
		string c = b.str();
		cout.width(25 - c.length());
		cout << "Wymagania ->" <<ekwipunek.at(i)->getWymagania() << endl << endl;
	}
}

void Gracz::dodajDoEkwipunku(Bron *_bron)
{
	ekwipunek.push_back(_bron);
}

int Gracz::getWielkoscEkwipunku()
{
	return ekwipunek.size();
}

void Gracz::setBronZEkwipunku(const int _wybor)
{
	if (ekwipunek.at(_wybor - 1)->getWymagania() <= sila)
	{
		bron = ekwipunek.at(_wybor - 1);
	}
	else
	{
		wypiszNaKonsole("Nie spelniasz wymagan!", 400);
	}
}

vector<Bron*> & Gracz::getEkwipunek()
{
	return ekwipunek;
}

void Gracz::ulecz()
{
	int wybor = decyzja("1.50pkt zycia - 200zlota\n2.100pkt zycia - 350zlota\n3.200pkt zycia - 650zlota\n4.Powrot", 1, 4);

	if (wybor == 1 && getZloto() >= 200)
	{
		dodajZloto(-200);
		punktyZycia += 50;
	}
	else if (wybor == 2 && getZloto() >= 350)
	{
		dodajZloto(-350);
		punktyZycia += 100;
	}
	else if (wybor == 3 && getZloto() >= 650)
	{
		dodajZloto(-650);
		punktyZycia += 200;
	}
	if (punktyZycia > maxPunktyZycia)
	{
		punktyZycia = maxPunktyZycia;
	}
}

void Gracz::zarzadzajEkwipunkiem(Menu &menu, Lochy &loch)
{
	pokazEkwipunek();
	if (getWielkoscEkwipunku() != 0)
	{
		cout << getWielkoscEkwipunku() + 1 << ". ZdejmijBron" << endl;
		int wybor = decyzja("0. Powrot", 0,getWielkoscEkwipunku()+1);
		if (wybor != 0 && wybor != getWielkoscEkwipunku() + 1)
		{
			setBronZEkwipunku(wybor);
		}
		else if (wybor == getWielkoscEkwipunku() + 1)
		{
			ustawBron(nullptr);
		}
	}
	else
	{
		wypiszNaKonsole("Brak broni w ekwipunku!", 500);
	}
	menu.kontynuuj(*this, loch);
}

void Gracz::setMaxPunktyZycia(const int _maxPunktyZycia)
{
	maxPunktyZycia = _maxPunktyZycia;
}

int Gracz::getMaxPunktyZycia()
{
	return maxPunktyZycia;
}