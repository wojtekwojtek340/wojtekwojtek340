#include "Menu.h"
#include <iostream>
#include <string>
#include "Gracz.h"
#include "Bron.h"
#include "Lochy.h"
#include "Szkielet.h"
#include "Pajak.h"
#include <fstream>
#include "Bron.h"
#include <functional>

using std::cin;
using std::cout;
using std::endl;
using std::string;

void Menu::menu1(Gracz &gracz, Lochy &loch)
{
	int wybor = decyzja("1.Nowa gra\n2.Wczytaj gre\n3.Wyjdz", 1, 3);

	switch (wybor)
	{
	case 1:
		kontynuuj(gracz,loch);
		break;
	case 2:
		wczytajGre(gracz,loch);
		break;
	case 3:
		wyjdz();
		break;
	default:
		break;
	}
}

void Menu::menu2(Gracz &_gracz, Lochy &_loch)
{
	cls();
	int wybor = decyzja("1.Kontynuuj\n2.Nowa gra\n3.Wczytaj gre\n4.Zapisz gre\n5.Wyjdz", 1,5);

	switch (wybor)
	{
	case 1:
		kontynuuj(_gracz, _loch);
		break;
	case 2:
		nowaGra(_gracz, _loch);
		break;
	case 3:
		wczytajGre(_gracz, _loch,1);
		break;
	case 4:
		zapiszGre(_gracz, _loch);
		break;
	case 5:
		wyjdz();
		break;
	default:
		break;
	}
}

void Menu::nowaGra(Gracz &gracz, Lochy &loch)
{
	gracz.setPunktyZycia(150);
	gracz.setMaxPunktyZycia(150);
	gracz.setSila(10);
	gracz.setZrecznosc(10);
	gracz.setPoziom(1);
	gracz.setDoswiadczenie(0);
	gracz.ustawBron(nullptr);
	gracz.setZloto(0);
	gracz.getEkwipunek().clear();
	loch.setWalkaBoss(false);
	loch.setPoziom(1);
	loch.setPokonaneStwory(0);

	cls();	
	gracz.wypiszStatystyki();

	int wybor = decyzja("1.Idz do lochu\n2.Otworz ekwipunek\n3.Powrot do menu", 1, 3, std::bind(&Gracz::wypiszStatystyki, &gracz));

	switch (wybor)
	{
	case 1:
		loch.wejdzDoLochu(gracz, loch, *this);
		break;
	case 2:
		cls();
		gracz.zarzadzajEkwipunkiem(*this, loch);
		break;
	case 3:
		menu2(gracz, loch);
		return;
		break;
	default:
		break;
	}
}

void Menu::wczytajGre(Gracz &gracz, Lochy &loch, const int flaga)
{
	int bufor;
	string sBufor;
	bool bBufor;
	vector <Bron> mieczyk;
	vector <string> id;
	vector <int> obrazenia;
	vector <int> wymagania;
	std::ifstream odczyt;
	cls();
	cout << "Wpisz 0 w celu powrotu." << endl;
	cout << "Podaj nazwe pliku: ";
	cin >> sBufor;
	if (sBufor != "0")
	{
		sBufor += ".txt";
		odczyt.open(sBufor, std::ifstream::in);
		odczyt >> sBufor;
		if (odczyt.is_open() == true && sBufor == "SAVE")
		{
			odczyt >> bufor;
			gracz.setMaxPunktyZycia(bufor);
			odczyt >> bufor;
			gracz.setPunktyZycia(bufor);
			odczyt >> bufor;
			gracz.setSila(bufor);
			odczyt >> bufor;
			gracz.setZrecznosc(bufor);
			odczyt >> bufor;
			gracz.setPoziom(bufor);
			odczyt >> bufor;
			gracz.setDoswiadczenie(bufor);
			odczyt >> bufor;
			gracz.setZloto(bufor);
			odczyt >> bBufor;
			loch.setWalkaBoss(bBufor);
			odczyt >> bufor;
			loch.setPoziom(bufor);
			odczyt >> bufor;
			loch.setPokonaneStwory(bufor);
			int wielkoscEkwipunku;
			odczyt >> wielkoscEkwipunku;
			for (int i = 0; i < wielkoscEkwipunku; i++)
			{
				std::getline(odczyt, sBufor);
				std::getline(odczyt, sBufor);
				id.push_back(sBufor);
				odczyt >> bufor;
				obrazenia.push_back(bufor);
				odczyt >> bufor;
				wymagania.push_back(bufor);
			}
			gracz.getEkwipunek().clear();
			string *kolejnosc = new string[wielkoscEkwipunku];
			for (unsigned int i = 0; i < id.size(); i++)
			{
				Bron miecz(id.at(i), obrazenia.at(i), wymagania.at(i));
				mieczyk.push_back(miecz);

			}
			int j = 0;
			int k = 0;
			for (unsigned int i = 0; i < id.size(); i++)
			{
				gracz.dodajDoEkwipunku(&mieczyk.at(k));
				k++;
			}
			int ubranaBron;
			odczyt >> ubranaBron;
			if (ubranaBron != -1)
			{
				gracz.setBronZEkwipunku(ubranaBron);
			}
			delete[] kolejnosc;
			odczyt.close();
			wypiszNaKonsole("odczyt pomyslny", 500);
		}
		else
		{
			wypiszNaKonsole("Blad odczytu!", 500);
			odczyt.close();
			if (flaga == 0)
			{
				menu1(gracz, loch);
			}
			else
			{
				menu2(gracz, loch);
			}
			return;
		}

		menu2(gracz, loch);
	}
	else
	{
		cls();
		if (flaga == 0)
		{
			menu1(gracz, loch);
		}
		else
		{
			menu2(gracz, loch);
		}
	}
}

void Menu::zapiszGre(Gracz &gracz, Lochy &loch)
{
	std::ofstream zapis;
	cls();
	cout << "Wpisz 0 w celu powrotu." << endl;
	cout << "Podaj nazwe pliku: ";
	string nazwa;
	cin >> nazwa;
	if (nazwa != "0" && nazwa != "Bronie")
	{
		nazwa += ".txt";
		zapis.open(nazwa, std::ofstream::out);
		if (zapis.is_open() == true)
		{
			int numerZalozonejBroni = -1;
			zapis << "SAVE" << endl;
			zapis << gracz.getMaxPunktyZycia() << endl;
			zapis << gracz.getPunktyZycia() << endl;
			zapis << gracz.getSila() << endl;
			zapis << gracz.getZrecznosc() << endl;
			zapis << gracz.getPoziom() << endl;
			zapis << gracz.getDoswiadczenie() << endl;
			zapis << gracz.getZloto() << endl;
			zapis << loch.getWalkaBoss() << endl;
			zapis << loch.getPoziom() << endl;
			zapis << loch.getPokonaneStwory() << endl;
			zapis << gracz.getWielkoscEkwipunku() << endl;
			for (int i = 0 ; i < gracz.getWielkoscEkwipunku(); i++)
			{
				zapis << gracz.getEkwipunek().at(i)->getNazwa() << endl;
				zapis << gracz.getEkwipunek().at(i)->getObrazenia() << endl;
				zapis << gracz.getEkwipunek().at(i)->getWymagania() << endl;
				try
				{
					if (gracz.getBronNazwa() == gracz.getEkwipunek().at(i)->getNazwa())
					{
						numerZalozonejBroni = i+1;
					}
				}
				catch (std::exception &blad)
				{
					numerZalozonejBroni = -1;
					blad.what();
				}
			}
			zapis << numerZalozonejBroni << endl;
			zapis.close();
			wypiszNaKonsole("Zapis pomyslny", 500);
			menu2(gracz, loch);
		}
		else
		{
			wypiszNaKonsole("Blad zapisu!", 500);
			return;
		}
	}
	else
	{
		menu2(gracz, loch);
	}
}

void Menu::wyjdz()
{
	return;
}

void Menu::kontynuuj(Gracz &gracz, Lochy &loch)
{
	cls();
	gracz.wypiszStatystyki();
	int wybor = decyzja("1.Idz do lochu\n2.Otworz ekwipunek\n3.Ulecz\n4.Powrot do menu", 1, 4, std::bind(&Gracz::wypiszStatystyki, &gracz));

	switch (wybor)
	{
	case 1:
		loch.wejdzDoLochu(gracz, loch, *this);
		break;
	case 2:
		cls();
		gracz.zarzadzajEkwipunkiem(*this, loch);
		break;
	case 3:
		gracz.ulecz();
		kontynuuj(gracz, loch);
		break;
	case 4:
		menu2(gracz, loch);
		return;
		break;
	default:
		break;
	}
}