#pragma once
#include <vector>
#include "Komunikacja.h"

class Bron;
class Menu;
class Lochy;

using std::string;
using std::vector;

class Gracz : public Komunikacja
{
	int punktyZycia;
	int maxPunktyZycia;
	int sila;
	int zrecznosc;
	int poziom;
	int doswiadczenie;
	int zloto;
	Bron *bron;
	vector<Bron*> ekwipunek;

public:
	Gracz();
	void dodajDoswiadczenie(const int _doswiadczenie);
	void dodajZloto(const int _zloto);
	void awans();
	void ustawBron(Bron *_bron);
	void wypiszStatystyki();
	int getPunktyZycia();
	int getSila();
	int getZrecznosc();
	int getPoziom();
	int getDoswiadczenie();
	int getZloto();
	string getBronNazwa();
	int getBronObrazenia();
	void setPunktyZycia(const int _punktyZycia);
	void setSila(const int _sila);
	void setZrecznosc(const int _zrecznosc);
	void setPoziom(const int _poziom);
	void setDoswiadczenie(const int _doswiadczenie);
	void setZloto(const int _zloto);
	void pokazEkwipunek();
	void dodajDoEkwipunku(Bron *_bron);
	int getWielkoscEkwipunku();
	void setBronZEkwipunku(const int _wybor);
	vector<Bron*> & getEkwipunek();
	void ulecz();
	void zarzadzajEkwipunkiem(Menu &menu, Lochy &loch);
	int getMaxPunktyZycia();
	void setMaxPunktyZycia(const int _maxPunktyZycia);
};