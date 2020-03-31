#include <iostream>
#include "Czas.h"
#include "Obrabiarka.h"

int main()
{
	Obrabiarka frezarka,frezarka2;
	Czas test(2, 2, 2);

	frezarka.dodajCzas(5,4,1);
	frezarka.dodajCzas(test);
	frezarka.dodajCzas(Czas(1, 2, 3));

	//frezarka.sumuj();

	frezarka.wyswietlCzas();

	/*std::cout << "1.Kopia obrabiarki zawierajaca ilosc podanych czasow" << std::endl;
	std::cout << "2.Kopia obrabiarki zawierajaca czasy z podanego przedzialu" << std::endl;
	std::cout << "3.Wyswietl czasy obrobki" << std::endl;
	std::cout << "4.Dodaj wszystkie i wyswietl czas obrobki" << std::endl;
	
	int menu;
	std::cin >> menu;
	
	switch (menu)
	{
	case 1:
		break;
	case 2:
		break;
	case 3:
		break;
	case 4:
		break;

	default:
		break;
	}*/

	std::cin.get();
	return 0;
}