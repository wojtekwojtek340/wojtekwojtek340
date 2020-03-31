#include <iostream>
#include <time.h>
#include "Kasyno.h"
#include "Karta.h"
#include "Gracz.h"
std::ostream& operator<< (std::ostream &wyjscie, Karta const& karta)
{
	wyjscie << karta.getFigura() << karta.getKolor();
	return wyjscie;
}

int main()
{
	{
		srand(time(NULL));

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

		system("cls");
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
	std::cin.get();
	return 0;
}