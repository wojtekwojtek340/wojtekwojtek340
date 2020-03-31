#include <iostream>
#include "Macierz.h"
#include "Solver.h"
#include "Blad.h"
#include <vector>
#include <fstream>
#include <string>
#include <sstream>

using std::vector;
using std::string;
using std::cout;
using std::cin;
using std::endl;

template <typename T>
void demo3(Macierz<T>& m) {
	m.element(0, 0) = 5.4;
	m.element(0, 1) = -1.5;
	m.element(0, 2) = 0.6;
	m.wolny(0) = 1.3;
	m.element(1, 0) = -0.7;
	m.element(1, 1) = 1.2;
	m.element(1, 2) = 1.8;
	m.wolny(1) = 1.85;
	m.element(2, 0) = 1.2;
	m.element(2, 1) = 0.8;
	m.element(2, 2) = -2.1;
	m.wolny(2) = -4.55;
}

template <typename T>
void demo4(Macierz<T>& m) {
	m.element(0, 0) = 0.2;
	m.element(0, 1) = 1.1;
	m.element(0, 2) = 0.1;
	m.element(0, 3) = 0.9;
	m.wolny(0) = 1.95;
	m.element(1, 0) = -1.2;
	m.element(1, 1) = 3.5;
	m.element(1, 2) = -2.6;
	m.element(1, 3) = 1.9;
	m.wolny(1) = 5.43;
	m.element(2, 0) = 0.8;
	m.element(2, 1) = -2.3;
	m.element(2, 2) = 1.2;
	m.element(2, 3) = -0.8;
	m.wolny(2) = -3.28;
	m.element(3, 0) = 0.2;
	m.element(3, 1) = -1.7;
	m.element(3, 2) = 1.9;
	m.element(3, 3) = 1.3;
	m.wolny(3) = -0.05;
}

bool czyZnak(const char & znak, const string &znaczek)
{
	for (int i = 0; i < znaczek.size(); i++)
	{
		if (znak == znaczek[i])
			return true;
	}
	return false;
}

template <typename T>
void zadanie3(std::ifstream &plik, Macierz<T> &macierz, vector<T> &wektor)
{
	string zawartosc;

	plik.seekg(2);
	std::getline(plik, zawartosc);
	int ileWierszy = 0;
	unsigned int znalezionaPozycja = zawartosc.find(" ");
	do
	{
		ileWierszy++;
		znalezionaPozycja = zawartosc.find(" ", znalezionaPozycja + 1);
	} while (znalezionaPozycja != std::string::npos);

	int dlugoscWiersza = ileWierszy + 1;
	plik.seekg(2);

	while (plik.eof() == false)
	{
		plik >> zawartosc;
		T liczba = 0;
		liczba = std::stof(zawartosc);
		wektor.push_back(liczba);
	}
	wektor.pop_back();
	macierz.setWierszeKolumny(ileWierszy, dlugoscWiersza);

	try
	{
		macierz.alokuj();
	}
	catch (std::exception &e) {
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}

	for (int i = 0; i < ileWierszy; i++)
	{
		for (int j = 0; j < dlugoscWiersza; j++)
		{
			if (j != ileWierszy)
				macierz.element(i, j) = wektor.at(i*dlugoscWiersza + j);
			else
				macierz.wolny(i) = wektor.at(i*dlugoscWiersza + j);
		}
	}
	macierz.pokaz();
}

template <typename T>
void zadanie4(std::ifstream &plik, Macierz<T> &m)
{
	plik.seekg(2);
	vector<string> pojemnik;
	T liczba;
	string zawartosc;


	while (plik.eof() == false)
	{
		getline(plik, zawartosc);
		pojemnik.push_back(zawartosc);
	}
	pojemnik.pop_back();

	string linia;
	string znaczek;

	linia = pojemnik.at(0);
	char test;
	int numer = 0;

	for (int j = 0; j < linia.size(); j++)
	{
		test = linia.at(j);
		if (isalpha(test))
		{
			znaczek += test;
			numer++;
		}
	}

	m.setWierszeKolumny(numer, numer + 1);

	try
	{
		m.alokuj();
	}
	catch (std::exception &e) {
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}

		// usuwa spacje z czegotamt
	for (int i = 0; i < pojemnik.size(); i++)
	{
		std::stringstream test;
		string tymcz;
		string linia = pojemnik.at(i);

		test << pojemnik.at(i);
		linia = "";

		while (!test.eof())
		{
			test >> tymcz;
			linia = linia + tymcz;
		}
		pojemnik.at(i) = linia;
	}

	for (int x = 0; x < numer; x++)
	{
		string czynnik;
		linia = pojemnik.at(x);

		int poz = -1;
		int c = 0;

		do
		{
			poz++;
			if (linia[poz] == '*')
				continue;
			else if (!czyZnak(linia[poz], znaczek))
			{
				if (linia[poz] != '+' && linia[poz] != '-')
					czynnik += linia[poz];
			}
			else
			{
				liczba = std::stof(czynnik);
				m.element(x, c) = liczba;
				c++;
				czynnik.clear();
			}
		} while (linia[poz] != '=');
		czynnik = linia.substr(poz + 1, linia.length());
		liczba = std::stof(czynnik);
		m.wolny(x) = liczba;
		czynnik.clear();
	}

	Solver<T> s(m);
	m.pokaz();

	try {
		s.rozwiaz();
	}
	catch (Blad &e) {
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}

	for (int i = 0; i < m.getIleWierszy(); i++)
	{
		for (int j = 0; j < m.getIleWierszy(); j++)
		{
			if (m.element(i, j) > 0.1)
				cout << m.element(i, j) << znaczek[j] << " ";
		}
		cout << "= " << m.wolny(i) << endl;
	}
	system("pause");
}
int main() {

	Macierz<double> m(4,5);
	try {
		m.alokuj();
	}
	catch(std::exception &e){
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}

	try {
		demo4(m);
	}
	catch (Blad &e) {
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}

	m.pokaz();
	std::cout << std::endl;

	Solver<double> s(m);
	try {
		s.rozwiaz();
	}
	catch (Blad &e) {
		std::cout << e.what() << std::endl;
		std::cin.get();
		exit(0);
	}
	m.pokaz();


	/////////////////////////////////////// ZADANIE 3 ///////////////////////////////////////////////////////


	string typ;
	std::ifstream plik;
	plik.open("macierz_5.txt", std::ifstream::in);
	if (plik.is_open() == false)
		exit(0);
	plik >> typ;

	if (typ == "F")
	{
		Macierz<float> macierz;
		vector<float> wektor;
		zadanie3(plik, macierz, wektor);
	}
	else if (typ == "D")
	{
		Macierz<double> macierz;
		vector<double> wektor;
		zadanie3(plik, macierz, wektor);		
	}
	plik.close();

	///////////////////////////////////////////// ZADANIE 4 /////////////////////////////////////////////////////////
	   
	plik.open("uklad_2.txt", std::ifstream::in);
	if (plik.is_open() == false)
		exit(0);
	plik >> typ;

	if (typ == "F")
	{
		Macierz<float> m;
		zadanie4(plik, m);
	}

	if (typ == "D")
	{
		Macierz<double> m;
		zadanie4(plik, m);
	}

	plik.close();

	std::cin.get();
	return 0;
}




//sfml