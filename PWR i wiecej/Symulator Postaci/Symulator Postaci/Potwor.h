#pragma once
#include "Lochy.h"

class Potwor
{
protected:
	int punktyZycia;
	int obrazenia;
	int doswiadczenie;
	int zloto;

public:
	virtual void zKimWalka() = 0;
	virtual int getPunktyZycia() = 0;
	virtual int getObrazenia() = 0;
	virtual int getDoswiadczenie() = 0;
	virtual int getZloto() = 0;
	virtual void setPunktyZycia(const int _punktyZycia) = 0;
	virtual void setObrazenia(const int _obrazenia) = 0;
	virtual void setDoswiadczenie(const int _doswiadczenie) = 0;

};