#pragma once
class Nadajnik;
#include "String.h"

class Wiadomosc
{
	int ID;
	String tresc;
	Nadajnik* zrodlo;

public:	
	Wiadomosc(int _id, const char* _str, Nadajnik &_zrodlo);
	void info();
};