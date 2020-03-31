#include "Cysterna.h"

Cysterna::Cysterna(double _pr, double wy)
	:Cylinder(_pr, wy)
{
	poziomNapelnienia = 0;
}

bool Cysterna::czyPelna()
{
	if (poziomNapelnienia == 0)
	{
		return false;
	}
	else
	{
		return true;
	}
}

double Cysterna::obliczObjetosc()
{
	double pole;
	pole = obliczPolePodstawy();
	double objetosc;
	objetosc = pole * wysokosc;
	return objetosc;
}
double Cysterna::obliczMase()
{
	double objetosc = obliczObjetosc();
	double masa = objetosc * gestoscCieczy;

	return masa;
}
void Cysterna::ustawPoziom(double _ilosc) 
{

}

