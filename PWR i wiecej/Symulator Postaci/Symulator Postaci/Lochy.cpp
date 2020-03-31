#include<iostream>
#include <sstream>
#include "Lochy.h"
#include "Potwor.h"
#include "Pajak.h"
#include "Szkielet.h"
#include "Gracz.h"
#include "Menu.h "
#include "Boss.h"
#include <fstream>
#include "Bron.h"
#include <functional>

using std::cin;
using std::cout;
using std::endl;
using std::stringstream;

Lochy::Lochy()
	:potwor(nullptr)
	, poziomLochu(1)
	,pokonaneStwory(0)
	,walkaBoss(false)
{
	wczytajBronie();
}

void Lochy::ustawPotwory(Potwor *_potwor)
{
	potwor = _potwor;
}

void Lochy::awans()
{
	if (pokonaneStwory >= poziomLochu * 10)
	{
		poziomLochu++;
		walkaBoss = true;
	}
}

void Lochy::wejdzDoLochu(Gracz &gracz, Lochy &loch , Menu &menu)
{
	cls();
	gracz.wypiszStatystyki();
	stringstream napis;
	napis << "Poziom lochu: " << getPoziom() << "\n" << "Pokonane stwory: " << getPokonaneStwory() << "\n\n" << "1.Walcz z losowym stworem\n2.Powrot" << endl;
	string a = napis.str();
	int wybor = decyzja(a, 1, 2, std::bind(&Gracz::wypiszStatystyki, &gracz));

	switch (wybor)
	{
	case 1:
		losujPrzeciwika(gracz, menu);
		break;
	case 2:
		menu.kontynuuj(gracz, loch);
		return;
		break;
	default:
		break;
	}	
}

int Lochy::getPoziom()
{
	return poziomLochu;
}

int Lochy::getPokonaneStwory()
{
	return pokonaneStwory;
}

void Lochy::setPoziom(const int _poziom)
{
	poziomLochu = _poziom;
}

void Lochy::setPokonaneStwory(const int _pokonaneStwory)
{
	pokonaneStwory = _pokonaneStwory;
}

void Lochy::losujPrzeciwika(Gracz &gracz, Menu &menu)
{
	int los = rand() % 2;
	if (los == 0 && walkaBoss == false)
	{
		Pajak pajak(*this);
		ustawPotwory(&pajak);
		walcz(gracz, menu);
		potwor = nullptr;
	}
	else if (los == 1 && walkaBoss == false)
	{
		Szkielet szkielet(*this);
		ustawPotwory(&szkielet);
		walcz(gracz, menu);
		potwor = nullptr;
	}
	else if (walkaBoss == true)
	{
		Boss boss(*this);
		ustawPotwory(&boss);
		walcz(gracz, menu);
		potwor = nullptr;
	}
}

void Lochy::walcz(Gracz &gracz, Menu &menu)
{
	cls();
	porownanieStatystyk(gracz);
	int wybor = decyzja("1.Atak\n2.Uciekaj", 1, 2, std::bind(&Lochy::porownanieStatystyk, &(*this), gracz));

	switch (wybor)
	{
	case 1:
		gracz.setPunktyZycia(gracz.getPunktyZycia() - potwor->getObrazenia());
		if (gracz.getPunktyZycia() <= 0)
		{
		cls();
		porownanieStatystyk(gracz);
		wypiszNaKonsole("KONIEC GRY", 1000);
		cin.get();
		return;
		}
		try 
		{
			potwor->setPunktyZycia(potwor->getPunktyZycia() - gracz.getBronObrazenia() - gracz.getSila());
		}
		catch (std::exception &blad)
		{
			potwor->setPunktyZycia(potwor->getPunktyZycia() - gracz.getSila());
		}

		if (potwor->getPunktyZycia() <= 0)
		{
			gracz.dodajDoswiadczenie(potwor->getDoswiadczenie());
			gracz.dodajZloto(potwor->getZloto());
			pokonaneStwory++;
			cls();
			porownanieStatystyk(gracz);
			if (walkaBoss)
			{
				walkaBoss = false;
				int los = rand() % miecze.size();
				gracz.dodajDoEkwipunku(&miecze.at(los));
				cout << "Dostales " << miecze.at(los).getNazwa() << endl;
				los = 0;
				wypiszNaKonsole("Udalo Ci sie pokonaj Bosa!", 1000);
			}
			else
			{
				wypiszNaKonsole("Udalo Ci sie pokonaj potwora!", 200);
			}
			awans();
			wejdzDoLochu(gracz, *this, menu);
		}
		else
		{
			walcz(gracz, menu);
		}
		break;
	case 2:
		wejdzDoLochu(gracz, *this, menu);
		break;
	default:
		break;
	}
}

void Lochy::porownanieStatystyk(Gracz &gracz)
{
	cout.width(50);
	potwor->zKimWalka();
	cout << endl;
	cout.width(30);
	cout << "Gracz";
	cout.width(25);
	cout << "Potwor" << endl << endl;
	cout << "Punkty Zycia:";
	cout.width(15);
	cout << gracz.getPunktyZycia();
	cout.width(23);
	cout << potwor->getPunktyZycia() << endl;
	cout << "Obrazenia:";
	cout.width(17);
	try 
	{
		cout << gracz.getBronObrazenia() + gracz.getSila();
	}
	catch (std::exception &blad)
	{
		cout << gracz.getSila();
	}
	cout.width(24);
	cout << potwor->getObrazenia() << endl << endl << endl;
}

void Lochy::wczytajBronie()
{
	std::ifstream odczyt;
	int bufor;
	string sBufor;
	vector <string> id;
	vector <int> obrazenia;
	vector <int> wymagania;
	odczyt.open("Bronie.txt", std::ifstream::in);
	odczyt >> sBufor;
	if (odczyt.is_open() == true && sBufor == "BRONIE")
	{
		int ile;
		odczyt >> ile;
		for (int i = 0; i < ile; i++)
		{
			std::getline(odczyt, sBufor);
			std::getline(odczyt, sBufor);
			id.push_back(sBufor);
			odczyt >> bufor;
			obrazenia.push_back(bufor);
			odczyt >> bufor;
			wymagania.push_back(bufor);
		}
		for (unsigned int i = 0; i < id.size(); i++)
		{
			Bron miecz(id.at(i), obrazenia.at(i), wymagania.at(i));
			miecze.push_back(miecz);

		}
	}
	else
	{
		wypiszNaKonsole("Blad odczytu plikow systemowych! Zamkniecie programu", 500);
	}
	odczyt.close();
}

void Lochy::setWalkaBoss(bool _walkaBoss)
{
	walkaBoss = _walkaBoss;
}

bool Lochy::getWalkaBoss()
{
	return walkaBoss;
}