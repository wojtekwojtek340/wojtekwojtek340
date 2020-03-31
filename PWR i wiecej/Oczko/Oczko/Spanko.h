#pragma once
#include <Windows.h>
#include <iostream>

class Spanko
{
private:
	bool spanie;
public:
	Spanko():spanie(true) {}
	void takSpij() { spanie = true; }
	void nieSpij() { spanie = false; }
	void spij(int _a) {if(spanie == true) Sleep(_a); }
};