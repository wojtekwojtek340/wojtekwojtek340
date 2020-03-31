#include "Gracz.h"
#include "Kasyno.h"
#pragma warning(disable : 4996)

Gracz::Gracz()
:ileKart(0),
punkty(0),
stanPass(false)
{	
	
}

bool Gracz::czyPass()
{
	return stanPass;
}

int Gracz::pokazPunkty2()
{
	return punkty;
}

char* Gracz::pokazNazwe()
{
	return nazwa;
}

void Gracz::przypiszDoKasyna(Kasyno &_kasyno)
{
	kasyno = &_kasyno;
}

void Gracz::wezKarte(Karta * _karta)
{
	if (ileKart < 10)
	{
		karty[ileKart] = _karta;
		punkty += karty[ileKart]->getWartosc();
		ileKart += 1;
	}	
}

void Gracz::pokazKarty()
{
	for (int i = 0; i < ileKart; i++)
	{
		//karty[i]->wypisz();
		std::cout << *karty[i] << std::endl;
	}
	std::cout << "\nIlosc punktow: " << punkty << "\n" << std::endl;
}

void Gracz::pass()
{
	stanPass = true;
}

void Gracz::niePass()
{
	stanPass = false;
}

void Gracz::ustawPunkty(int _ile)
{
	punkty = _ile;
}

void Gracz::pokazPunkty()
{
	std::cout << "Liczba punktow: " << punkty << std::endl;
}

void Gracz::nadajNazwe(char* _nazwa)
{
	strcpy(nazwa, _nazwa);
}