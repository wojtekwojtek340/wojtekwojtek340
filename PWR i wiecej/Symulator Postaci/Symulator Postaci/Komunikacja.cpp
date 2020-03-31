#include "Komunikacja.h"
#include <iostream>
#include <Windows.h>
#include <sstream>
#include "Gracz.h"
#include "Lochy.h"

using std::cin;
using std::cout;
using std::endl;
using std::stringstream;

void Komunikacja::cls()
{
	system("cls");
}

int Komunikacja::decyzja(const string &komunikat, const int zakresOd, const int zakresDo, std::function<void()>foo)
{
	int wybor;
	cout << komunikat << endl;
	cin >> wybor;

	while (cin.fail() == true || wybor < zakresOd || wybor > zakresDo)
	{
		stringstream strumien;
		strumien << "podaj liczbe z zakresu " << zakresOd << "..." << zakresDo << endl;
		string wiadomosc = strumien.str();
		wypiszNaKonsole(wiadomosc, 500);
		cin.clear();
		cin.ignore(256, '\n');
		foo();
		cout << komunikat << endl;
		cin >> wybor;
	}
	return wybor;
}

int Komunikacja::decyzja(const string &komunikat, const int zakresOd, const int zakresDo)
{
	int wybor;
	cout << komunikat << endl;

	cin >> wybor;

	while (cin.fail() == true || wybor < zakresOd || wybor > zakresDo)
	{
		stringstream strumien;
		strumien << "podaj liczbe z zakresu " << zakresOd << "..." << zakresDo << endl;
		string wiadomosc = strumien.str();
		wypiszNaKonsole(wiadomosc, 500);
		cin.clear();
		cin.ignore(256, '\n');
		cout << komunikat << endl;
		cin >> wybor;
	}
	return wybor;
}

void Komunikacja::wypiszNaKonsole(const string & wiadomosc, const int spanie)
{
	cout << wiadomosc << endl;
	Sleep(spanie);
	cls();
}