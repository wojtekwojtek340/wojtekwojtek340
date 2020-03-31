#pragma once
#include "Gracz.h"

class Bot : public Gracz
{
	int odwaga;
public:
	int getOdwaga() { return odwaga; }
	void nadajNazweBota(int _a);
	void setOdwaga(int _odwaga) { odwaga = _odwaga; }
};