#include<iostream>
#include "Bron.h"

using std::cin;
using std::cout;
using std::endl;

Bron::Bron()
	:wymagania(0)
	,nazwa("Miecz")
	,obrazenia(100)
{}

Bron::Bron(const string _nazwa, const int _obrazenia, const int _wymaganaSila)
	:wymagania(_wymaganaSila)
{
	nazwa = _nazwa;
	obrazenia = _obrazenia;
}

string Bron::getNazwa()
{
	return nazwa;
}

int Bron::getObrazenia()
{
	return obrazenia;
}

int Bron::getWymagania()
{
	return wymagania;
}

void Bron::setNazwa(const string _nazwa)
{
	nazwa = _nazwa;
}

void Bron::setObrazenia(const int _obrazenia)
{
	obrazenia = _obrazenia;
}

void Bron::setWymagania(const int _wymagania)
{
	wymagania = _wymagania;
}

void Bron::wypiszWymagania()
{
	cout << "Wymagania: " << wymagania << endl;
}
