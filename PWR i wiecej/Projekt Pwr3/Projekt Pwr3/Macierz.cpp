//#include <iomanip>
//#include <iostream>
//#include "Macierz.h"
//
//
//
//Macierz<T>::Macierz(int _wiersze, int _kolumny) : ile_wierszy(_wiersze), dlugosc_wiersza(_kolumny) {
//}
//
//
//Macierz<T>::~Macierz() {
//	delete[] dane;
//	delete[] wiersze;
//}
//
//void Macierz<T>::zeruj() {
//	for (int i = 0; i < ile_wierszy*dlugosc_wiersza; ++i) {
//		dane[i] = 0;
//	}
//}
//
//void Macierz<T>::pokaz() const {
//	using std::cout;
//	using std::endl;
//	using std::setw;
//	using std::fixed;
//	using std::setprecision;
//	for (int i = 0; i < ile_wierszy; ++i) {
//		for (int j = 0; j < dlugosc_wiersza - 1; ++j) {
//			cout << setw(8) << setprecision(4) << fixed << wiersze[i][j];
//		}
//		cout << "  |" << setw(8) << setprecision(4) << wiersze[i][dlugosc_wiersza - 1] << endl;
//	}
//}
//
//void Macierz<T>::alokuj()
//{
//	dane = new double[ile_wierszy*dlugosc_wiersza];
//	wiersze = new double*[ile_wierszy];
//
//	for (int i = 0; i < ile_wierszy; ++i) {
//		wiersze[i] = dane + i * dlugosc_wiersza;
//	}
//}
