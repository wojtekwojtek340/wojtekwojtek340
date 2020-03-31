#include <iostream>
#include "Czas.h"
#include "Obrabiarka.h"

int main()
{
	Obrabiarka frezarka, frezarka2;
	Czas test(2, 2, 2);

	frezarka.dodajCzas(4, 4, 4);
	frezarka.dodajCzas(5, 5, 5);
	frezarka.dodajCzas(1, 1, 1);
	frezarka.dodajCzas(test);
	frezarka.dodajCzas(Czas(3, 3, 3));
	
	frezarka.wyswietlCzas();
	frezarka.IloscCzasow();

	for (int i = 0;; i++)
	{
		std::cout << "\n1.Kopia obrabiarki zawierajaca ilosc podanych czasow" << std::endl;
		std::cout << "2.Kopia obrabiarki zawierajaca czasy z podanego przedzialu" << std::endl;
		std::cout << "3.Wyjscie" << std::endl;

		int menu;
		while (!(std::cin >> menu))
		{
			std::cin.clear();
			std::cin.sync();
			std::cin.ignore();
		}

		switch (menu)
		{
		case 1:
			system("cls");
			std::cout << "Podaj ilosc pierwszych czasow do nowej obrabiarki" << std::endl;
			int ilosc;
			while (!(std::cin >> ilosc))
			{
				std::cin.clear();
				std::cin.sync();
				std::cin.ignore();
			}
			frezarka2 = frezarka.kopiaIlosc(ilosc);
			frezarka2.wyswietlCzas();
			break;
		case 2:
			system("cls");
			std::cout << "Podaj gorna wartosc czasowa do nowej obrabiarki" << std::endl;
			std::cout << "Nalezy podac sekundy, minuty, godziny" << std::endl;
			int s,m,h;
			while (!(std::cin >> s >> m >> h))
			{
				std::cin.clear();
				std::cin.sync();
				std::cin.ignore();
			}
			system("cls");
			frezarka2 = frezarka.kopiaDoCzasu(s, m, h);
			std::cout << "Wprowadzony czas wynosi: ";
			Czas(s, m, h).sprawdzCzas();
			std::cout << "Czasy obrabiarki ktorych suma jest mniejsza lub rowna:" << std::endl;
			frezarka2.wyswietlCzas();
			break;
		case 3:
			exit(0);
			break;
		default:
			break;
		}
	}
	std::cin.get();
	return 0;
}