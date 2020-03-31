#pragma once
#include "Potwor.h"

class Boss : public Potwor
{
	int punktyZycia;
	int obrazenia;
	int doswiadczenie;

public:
	Boss(Lochy &_loch);
	void zKimWalka();
	int getPunktyZycia();
	int getObrazenia();
	int getDoswiadczenie();
	int getZloto();
	void setPunktyZycia(const int _punktyZycia);
	void setObrazenia(const int _obrazenia);
	void setDoswiadczenie(const int _doswiadczenie);
};