#pragma once
#include "Karta.h"
class Kasyno;

class Gracz
{
protected:
	Kasyno* kasyno;
	Karta *karty[10];
	int ileKart;
	int punkty;
	bool stanPass;
	char nazwa[20];
public:
	Gracz();
	bool czyPass();
	int pokazPunkty2();
	int ileKartt() { return ileKart; }
	char* pokazNazwe();
	char pokazFigure(int _ile) { return karty[_ile]->getFigura(); }
	char pokazKolor(int _ile) { return karty[_ile]->getKolor(); }
	void przypiszDoKasyna(Kasyno &kasyno);
	void wezKarte(Karta * _karta);
	void pokazKarty();
	void pass();
	void niePass();
	void ustawPunkty(int _ile);
	void pokazPunkty();
	void nadajNazwe(char* _nazwa);
	virtual void setOdwaga(int _odwaga)	{ int odwaga = _odwaga; }
	virtual void nadajNazweBota(int _a) {}
	virtual int getOdwaga() { return 1; }
};