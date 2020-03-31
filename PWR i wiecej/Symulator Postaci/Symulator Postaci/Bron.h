#pragma once
#include <string>

using std::string;

class Bron
{
	string nazwa;
	int obrazenia;
	int wymagania;

public:
	Bron();
	Bron(const string _nazwa, const int _obrazenia, const int _wymaganaSila);
	string getNazwa();
	int getObrazenia();
	int getWymagania();
	void setNazwa(const string _nazwa);
	void setObrazenia(const int _obrazenia);
	void setWymagania(const int _wymagania);
	void wypiszWymagania();
};