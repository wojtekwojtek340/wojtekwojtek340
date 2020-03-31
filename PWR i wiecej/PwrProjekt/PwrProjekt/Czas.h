#pragma once
#include <iostream>

class Czas
{
	int sekunda, minuta, godzina;
public:
	void sprawdzCzas();
	Czas(int _g = 0, int _m = 0, int _s = 0);
	Czas& operator+(Czas& _czas);
	bool operator==(Czas& _czas);
	bool operator<(Czas& _czas);
};
