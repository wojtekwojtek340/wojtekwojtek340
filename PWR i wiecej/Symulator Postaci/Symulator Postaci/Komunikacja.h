#pragma once
#include <string>
#include <functional>

class Gracz;
class Lochy;

using std::string;

class Komunikacja
{
public:
	void cls();
	int decyzja(const string &komunikat, const int zakresOd, const int zakresDo);
	int decyzja(const string &komunikat, const int zakresOd, const int zakresDo, std::function<void()> foo);
	void wypiszNaKonsole(const string &wiadomosc, const int spanie);
};