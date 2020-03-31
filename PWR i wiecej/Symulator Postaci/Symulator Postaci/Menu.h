#pragma once
#include "Komunikacja.h"

class Gracz;
class Lochy;

class Menu : public Komunikacja
{
public:
	void menu1(Gracz &gracz, Lochy &loch);
	void menu2(Gracz &_gracz, Lochy &_loch);
	void nowaGra(Gracz &gracz, Lochy &loch);
    void wczytajGre(Gracz &gracz, Lochy &loch, const int flaga = 0);
	void zapiszGre(Gracz &gracz, Lochy &loch);
	void wyjdz();
	void kontynuuj(Gracz &gracz, Lochy &loch);	
};