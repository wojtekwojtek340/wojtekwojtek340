#pragma once
#include "Komunikacja.h"
#include <vector>
#include "Bron.h"

class Potwor;
class Gracz;
class Menu;
class Bron;

using std::vector;

class Lochy : public Komunikacja
{
	Potwor *potwor;
	int poziomLochu;
	int pokonaneStwory;
	bool walkaBoss;
	vector<Bron> miecze;

public:
	Lochy();
	void ustawPotwory(Potwor *_potwor);
	void awans();
	void wejdzDoLochu(Gracz &gracz,Lochy &loch , Menu &menu);
	int getPoziom();
	int getPokonaneStwory();
	void setPoziom(const int _poziom);
	void setPokonaneStwory(const int _pokonaneStwory);
	void losujPrzeciwika(Gracz &gracz, Menu &menu);
	void walcz(Gracz &gracz, Menu &menu);
	void porownanieStatystyk(Gracz &gracz);
	void wczytajBronie();
	bool getWalkaBoss();
	void setWalkaBoss(bool _walkaBoss);
};