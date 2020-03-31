#include <fstream>
#include "Kasyno.h"
#include <iomanip>


Kasyno::Kasyno(int _a, int _b)
	:iloscGraczy(_a),
	iloscBotow(_b),
	numerKarty(-1)
{
	gracz = new Gracz*[iloscGraczy+iloscBotow];
	
	for (int i = 0; i< iloscGraczy; i++)
	{
		gracz[i] = new Gracz;
	}

	for (int i = 0; i < iloscBotow; i++)
	{
		gracz[i + iloscGraczy] = new Bot;
	}

	int k = 0;
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 13; j++)
		{
			karty[k].setKolor(i);
			karty[k].setWartosc(j);
			k++;
		}
	}
}

Kasyno::~Kasyno()
{
	for (int i = 0; i < iloscGraczy + iloscBotow; i++)
	{
		delete gracz[i];
	}

	delete[] gracz;
}

Karta * Kasyno::dajKarte()
{
	numerKarty += 1;
	return &karty[numerKarty];
}

void Kasyno::przetasuj()
{
	Karta tymcz;

	for (int i = 0; i < 100; i++)
	{
		int j = rand() % 52;
		int k = rand() % 52;
		
		tymcz = karty[j];
		karty[j] = karty[k];
		karty[k] = tymcz;
	}
}

void Kasyno::ustawGraczy(int _ileGraczy)
{
	char nazwa[20];

	system("cls");

	for (int i = 0; i < _ileGraczy; i++)
	{
		std::cout << "Graczu " << i + 1 << " podaj nazwe:" << std::endl;
		std::cin >> std::setw(20) >> nazwa;

		gracz[i]->nadajNazwe(nazwa);
		gracz[i]->przypiszDoKasyna(*this);
		gracz[i]->wezKarte(dajKarte());
		gracz[i]->wezKarte(dajKarte());
	}
}

void Kasyno::ustawBoty(int _ileBotow)
{
	int menu;
	
	system("cls");
	std::cout << "Wybierz tryb botow:" << std::endl;
	std::cout << "1.Ryzykujacy\n2.Normalny\n3.Zachowawczy\n" << std::endl;

	std::cin >> menu;

	while (std::cin.fail() == true || menu < 1 || menu > 3)
	{
		system("cls");
		std::cout << "Wybierz tryb botow:" << std::endl;
		std::cout << "1.Ryzykujacy\n2.Normalny\n3.Zachowawczy\n" << std::endl;
		std::cin.clear();
		std::cin.ignore(256, '\n');
		std::cin >> menu;
	}

	switch (menu)
	{
	case 1:
		for (int j = 0; j < iloscBotow; j++)
		{
			gracz[j+iloscGraczy]->setOdwaga(18);
		}
		break;
	case 2:
		for (int j = 0; j < iloscBotow; j++)
		{
			gracz[j + iloscGraczy]->setOdwaga(17);
		}
		break;
	case 3:
		for (int j = 0; j < iloscBotow; j++)
		{
			gracz[j + iloscGraczy]->setOdwaga(16);
		}
		break;
	default:
		break;
	}

	for (int i = 0; i < iloscBotow; i++)
	{
		gracz[i + iloscGraczy]->nadajNazweBota(i);
		gracz[i + iloscGraczy]->przypiszDoKasyna(*this);
		gracz[i + iloscGraczy]->wezKarte(dajKarte());
		gracz[i + iloscGraczy]->wezKarte(dajKarte());
	}
}

void Kasyno::ktoWygral(int _ileGraczy, int _ileBotow)
{
	int (*punkty)[2];
	punkty = new int[_ileGraczy + _ileBotow][2];

	for (int i = 0; i < _ileGraczy + _ileBotow; i++)
	{
		punkty[i][0] = i;
		punkty[i][1] = gracz[i]->pokazPunkty2();
	}

	for (int j = 0; j < _ileGraczy + _ileBotow; j++)
	{
		for (int i = 1; i < _ileGraczy + _ileBotow; i++)
		{
			if (punkty[i - 1][1] < punkty[i][1])
			{
				int temp1;
				int temp2;

				temp1 = punkty[i - 1][0];
				temp2 = punkty[i - 1][1];

				punkty[i - 1][0] = punkty[i][0];
				punkty[i - 1][1] = punkty[i][1];
				
				punkty[i][0] = temp1;
				punkty[i][1] = temp2;
			}
		}		
	}
	
	for (int i = 0; i < _ileGraczy + _ileBotow; i++)
	{

		if (punkty[i][1] < 22)
		{
			std::cout << gracz[punkty[i][0]]->pokazNazwe() << " Liczba punktow: " << punkty[i][1] << std::endl;			
		}
	}

	for (int i = 0; i < _ileGraczy + _ileBotow; i++)
	{
		if (punkty[i][1] > 21)
		{
			std::cout << gracz[punkty[i][0]]->pokazNazwe() << " PRZEGRANA. Liczba punktow: " << punkty[i][1] << std::endl;
		}
	}

	std::cout << std::endl;
	delete[] punkty;
}

void Kasyno::graj()
{
	int menu, k = 0;
	bool b = false;

	przetasuj();
	ustawGraczy(iloscGraczy);
	ustawBoty(iloscBotow);
	ustawSpanie();

	while(b == false)
	{
		for (int j = 0; j < iloscGraczy; j++)
		{
			int pkt = gracz[j]->pokazPunkty2();
			if (pkt == 22 && gracz[j]->ileKartt() == 2)
			{
				system("cls");
				gracz[j]->ustawPunkty(21);
				gracz[j]->pass();
				k++;
				std::cout << gracz[j]->pokazNazwe() << " wylosowal 2 ASY, automatyczna wygrana" << std::endl;
				spij.spij(2000);
			}

			if (gracz[j]->czyPass() == false)
			{
				system("cls");
				std::cout << gracz[j]->pokazNazwe() << "\n" << std::endl;
				gracz[j]->pokazKarty();
				std::cout << "1. Dobierz\n" << "2. Pass" << std::endl;

				std::cin >> menu;
				if (std::cin.fail() == true)
				{
					std::cout << "blad" << std::endl;
					std::cin.clear();
					std::cin.ignore(256, '\n');
				}

				switch (menu)
				{
				case 1:
					gracz[j]->niePass();
					gracz[j]->wezKarte(dajKarte());
					system("cls");
					std::cout << gracz[j]->pokazNazwe() << "\n" << std::endl;
					gracz[j]->pokazKarty();
					spij.spij(1000);
					break;
				case 2:
					gracz[j]->pass();
					k++;
					break;
				default:
					break;
				}
				int pkt = gracz[j]->pokazPunkty2();
				if (pkt >= 21)
				{
					gracz[j]->pass();
					k++;
				}
			}
		}

		for (int i = 0; i < iloscBotow; i++)
		{
			int pkt = gracz[i+iloscGraczy]->pokazPunkty2();
			if (pkt == 22 && gracz[i+iloscGraczy]->ileKartt() == 2)
			{
				system("cls");
				gracz[i+iloscGraczy]->ustawPunkty(21);
				gracz[i + iloscGraczy]->pass();
				std::cout << gracz[i + iloscGraczy]->pokazNazwe() << " wylosowal 2 ASY, automatyczna wygrana" << std::endl;
				k++;
				spij.spij(2000);
			}			
			
			if (gracz[i + iloscGraczy]->czyPass() == false)
			{
				system("cls");
				std::cout << gracz[i + iloscGraczy]->pokazNazwe() << "\n" << std::endl;
				gracz[i + iloscGraczy]->pokazKarty();
				std::cout << "hmmmm..." << std::endl;
				spij.spij(1000);

				int pkt = gracz[i + iloscGraczy]->pokazPunkty2();

				if (pkt < gracz[i + iloscGraczy]->getOdwaga())
				{
					system("cls");
					std::cout << gracz[i + iloscGraczy]->pokazNazwe() << "\n" << std::endl;
					gracz[i + iloscGraczy]->wezKarte(dajKarte());
					gracz[i + iloscGraczy]->pokazKarty();
					std::cout << "Dobieram!!!" << std::endl;
					spij.spij(1000);
					if (gracz[i + iloscGraczy]->pokazPunkty2() > 20)
					{
						gracz[i + iloscGraczy]->pass();
						k++;
					}
				}
				else
				{
					gracz[i + iloscGraczy]->pass();
					std::cout << "Pass..." << std::endl;
					spij.spij(1500);
					k++;
				}
			}
		}
		if (k == iloscGraczy + iloscBotow && b == false)
		{
			system("cls");
			ktoWygral(iloscGraczy, iloscBotow);

			std::cout << "1. Nowa gra\n" << "2. Wyjscie\n" << "3.Zapisz" << std::endl;

			std::cin >> menu;
			if (std::cin.fail() == true)
			{
				std::cout << "blad" << std::endl;
				std::cin.clear();
				std::cin.ignore(256, '\n');
			}

			switch (menu)
			{
			case 1:
				nowaGra();
			case 2:
				b = true;
				break;
			case 3:
				zapisz(iloscGraczy, iloscBotow);
				break;
			default:
				break;
			}
		}
	}
}

void Kasyno::nowaGra()
{
	system("cls");
	int ileGraczy, ileBotow;
	std::cout << "Podaj Ilosc Graczy: " << std::endl;
	std::cin >> ileGraczy;

	while (std::cin.fail() == true || ileGraczy < 1 || ileGraczy > 3)
	{
		system("cls");
		std::cout << "Podaj Ilosc Graczy: " << std::endl;
		std::cin.clear();
		std::cin.ignore(256, '\n');
		std::cin >> ileGraczy;
	}

	std::cout << "Podaj Ilosc Botow: " << std::endl;
	std::cin >> ileBotow;

	while (std::cin.fail() == true || ileBotow < 1 || ileBotow > 3)
	{
		system("cls");
		std::cout << "Podaj Ilosc Botow: " << std::endl;
		std::cin.clear();
		std::cin.ignore(256, '\n');
		std::cin >> ileBotow;
	}

	Kasyno test(ileGraczy, ileBotow);
	test.graj();
}

void Kasyno::zapisz(int _ileGraczy, int _ileBotow)
{
	std::ofstream plik;
	plik.open("test.txt", std::ofstream::out);
	std::cout << plik.is_open() << std::endl;
	for (int i = 0; i < _ileGraczy + iloscBotow; i++)
	{		
		plik << gracz[i]->pokazNazwe();

		int a = strlen(gracz[i]->pokazNazwe());

		plik.seekp(-a, std::ios_base::cur);
		plik.seekp(25, std::ios_base::cur);

		int b = 0;

		int ile = gracz[i]->ileKartt();

		for (int j = 0; j < ile; j++)
		{
			plik << gracz[i]->pokazFigure(j) << gracz[i]->pokazKolor(j) << "  ";
			b += 4;
		}
		
		b += 25;
		plik.seekp(-b, std::ios_base::cur);
		plik.seekp(60, std::ios_base::cur);

		plik << gracz[i]->pokazPunkty2() << std::endl;
	}

	plik.close();
}

void Kasyno::ustawSpanie()
{
	int menu;

	system("cls");
	std::cout << "1. Wlaczone spanie\n2. Wylaczone spanie" << std::endl;
	std::cin >> menu;

	while (std::cin.fail() == true)
	{
		system("cls");
		std::cout << "1. Wlaczone spanie\n2. Wylaczone spanie" << std::endl;
		std::cin.clear();
		std::cin.ignore(256, '\n');
		std::cin >> menu;
	}

	switch (menu)
	{
	case 1:
		spij.takSpij();
		break;
	case 2:
		spij.nieSpij();
		break;
	default:
		break;
	}
}