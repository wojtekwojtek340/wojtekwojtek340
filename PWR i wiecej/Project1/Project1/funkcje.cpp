#include "Obrabiarka.h"
#include "Czas.h"

void Obrabiarka::sumuj()
{
	Czas suma;

	for (int i = 0; i < ileCzasow; i++)
	{
		suma = suma + czasy[i];
	}

	ileCzasow = 1;

	delete[] czasy;
	
	czasy = new Czas[1];
	
	czasy[0] = suma;
	
}

void Obrabiarka::wyswietlCzas()
{
	for (int i = 0; i < ileCzasow; i++)
	{
		czasy[i].sprawdzCzas();
	}
}

void Obrabiarka::wyswietlCzas(const int _wybranyCzas)
{
	if (_wybranyCzas <= ileCzasow)
	{
		czasy[_wybranyCzas - 1].sprawdzCzas();
	}
	else
	{
		std::cout << "Numer czasu jest wiekszy od ilosci posiadanych czasow" << std::endl;
	}
}

void Obrabiarka::dodajCzas(int _s, int _m, int _h)
{
	Czas ptr(_s, _m, _h);
	dodajCzas(ptr);
}

void Obrabiarka::dodajCzas(const Czas _czas)
{
	if (ileCzasow == 0)
	{
		ileCzasow += 1;
		czasy = new Czas[ileCzasow];
		czasy[0] = _czas;
	}
	else
	{
		ileCzasow += 1;

		Czas *temp = new Czas[ileCzasow];

		for (int i = 0; i < ileCzasow - 1; i++)
		{
			temp[i] = czasy[i];
		}

		temp[ileCzasow - 1] = _czas;

		delete[] czasy;

		czasy = temp;
	}

}

Obrabiarka& Obrabiarka::operator=(const Obrabiarka& _inna)
{
	if (&_inna == this)
	{
		return *this;
	}
	delete[] czasy;
	ileCzasow = _inna.ileCzasow;
	czasy = new Czas[ileCzasow];

	for (int i = 0; i < ileCzasow; i++)
	{

	}

	return *this;
}

Obrabiarka::Obrabiarka(const Obrabiarka& _inna)
{
	ileCzasow = _inna.ileCzasow;
	czasy = new Czas[ileCzasow];

	for (int i = 0; i < ileCzasow; i++)
	{
		czasy[i] = _inna.czasy[i];
	}
}

Obrabiarka::Obrabiarka()
{
	ileCzasow = 0;
}

Obrabiarka::~Obrabiarka()
{
	delete[] czasy;
}

void Czas::sprawdzCzas()
{
	std::cout << godzina << "h:" << minuta << "m:" << sekunda << "s" << std::endl;
}

Czas::Czas(int _s, int _m, int _g)
{
	if (_g >= 0 && _m >= 0 && _s >= 0)
	{
		while (_s >= 60)
		{
			_s -= 60;
			_m += 1;
		}

		while (_m >= 60)
		{
			_m -= 60;
			_g += 1;
		}

		godzina = _g;
		minuta = _m;
		sekunda = _s;
	}
	else
	{
		std::cout << "ERROR" << std::endl;
		godzina = 0;
		minuta = 0;
		sekunda = 0;
		system("pause");
	}
}

Czas& Czas::operator+(Czas& _czas)
{
	sekunda += _czas.sekunda;
	minuta += _czas.minuta;
	godzina += _czas.godzina;
	return *this;
}

bool Czas::operator==(Czas& _czas)
{
	if (godzina == _czas.godzina && minuta == _czas.minuta && sekunda == _czas.sekunda)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool Czas::operator<(Czas& _czas)
{
	if (godzina < _czas.godzina)
	{
		return true;
	}
	else if (godzina >= _czas.godzina && minuta < _czas.minuta)
	{
		return true;
	}
	else if (godzina >= _czas.godzina && minuta >= _czas.minuta && sekunda < _czas.sekunda)
	{
		return true;
	}
	else
	{
		return false;
	}
}