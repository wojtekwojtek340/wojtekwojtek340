#pragma once
#include <iostream>
#include "Karta.h"
#include "Gracz.h"
#include "Bot.h"
#include "Spanko.h"

class Kasyno
{
	Karta karty[52];
	Gracz **gracz;
	Spanko spij;
	int numerKarty;
	int iloscGraczy;
	int iloscBotow;
public:
	Kasyno(int _a, int _b);
	~Kasyno();
	Karta * dajKarte();
	void przetasuj();
	void ustawGraczy(int _ileGraczy);
	void ustawBoty(int _ileBotow);
	void ktoWygral(int _ileGraczy, int _ileBotow);
	void graj();
	void nowaGra();
	void zapisz(int _ileGraczy, int _ileBotow);
	void ustawSpanie();
};
