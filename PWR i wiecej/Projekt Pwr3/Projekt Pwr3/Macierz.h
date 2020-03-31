#pragma once
#include <iomanip>
#include <iostream>
#include "Blad.h"

template <typename T>
class Macierz {
	int ile_wierszy;
	int dlugosc_wiersza;
	T *dane;
	T **wiersze;

public:
	Macierz() {}
	Macierz(int _wiersze, int _kolumny) : ile_wierszy(_wiersze), dlugosc_wiersza(_kolumny) {
	};
	~Macierz() {
		delete[] dane;
		delete[] wiersze;
	}
	// Usuniety konstruktor kopiujacy i operator przypisania powoduje,
	// ze obiektow tej klasy nie da sie przekazywac przez wartosc.
	// Jest to rowniez sposob dotrzymania zasady trzech.
	void operator=(const Macierz& other_) = delete;
	Macierz(const Macierz& other_) = delete;
	
	void setWierszeKolumny(int _wiersze, int _kolumny) {
		ile_wierszy = _wiersze;
		dlugosc_wiersza = _kolumny;
	}

	void zeruj() {
		for (int i = 0; i < ile_wierszy*dlugosc_wiersza; ++i) {
			dane[i] = 0;
		}
	}
	void pokaz()  const {
		using std::cout;
		using std::endl;
		using std::setw;
		using std::fixed;
		using std::setprecision;
		for (int i = 0; i < ile_wierszy; ++i) {
			for (int j = 0; j < dlugosc_wiersza - 1; ++j) {
				cout << setw(8) << setprecision(4) << fixed << wiersze[i][j];
			}
			cout << "  |" << setw(8) << setprecision(4) << wiersze[i][dlugosc_wiersza - 1] << endl;
		}
	}

	int getIleWierszy() { return ile_wierszy; }
	T& element(int i, int j) {
		if (i > ile_wierszy - 1 || i < 0 || j > dlugosc_wiersza - 1 || j < 0)
			throw Blad("Wyjscie poza rozmiar tablicy.");
		return wiersze[i][j];
	}
	T& wolny(int i) {
		if (i<0 || i > ile_wierszy - 1)
			throw Blad("wyjscie poza rozmiar tablicy");
		return wiersze[i][dlugosc_wiersza - 1];
	}
	void alokuj() {
		dane = new T[ile_wierszy*dlugosc_wiersza];
		wiersze = new T*[ile_wierszy];

		for (int i = 0; i < ile_wierszy; ++i) {
			wiersze[i] = dane + i * dlugosc_wiersza;
		}
	}

	/*void zamienWiersze(int stary, int nowy)
	{
		if (stary < 0 || nowy < 0 || nowy > dlugosc_wiersza || stary > dlugosc_wiersza)
			throw Blad("zamiana miejscami nieudana.");
		
	}*/
};