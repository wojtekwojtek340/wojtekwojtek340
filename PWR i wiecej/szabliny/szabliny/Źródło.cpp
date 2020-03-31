#include <algorithm>
#include <iostream>
#include <vector>

using std::vector;
using std::copy;

//  Zadanie do laboratorium 11 (wektory)
//  Tresc w funkcji main

class Czas {
	int godziny;
	int minuty;
	int sekundy;

	void zabezpiecz() {
		minuty += sekundy / 60;
		sekundy %= 60;
		godziny += minuty / 60;
		minuty %= 60;
		if (godziny < 0) godziny = 0;
		if (minuty < 0) minuty = 0;
		if (sekundy < 0) sekundy = 0;
	}

public:
	Czas(int s = 0, int m = 0, int h = 0) : godziny(h), minuty(m), sekundy(s) {
		zabezpiecz();
	}

	int getGodziny() const { return godziny; }
	int getMinuty() const { return minuty; }
	int getSekundy() const { return sekundy; }
	int doSekund() const { return godziny * 3600 + minuty * 60 + sekundy; }
	void setGodziny(int h) { godziny = h; }
	void setMinuty(int m) { if (m >= 0 && m <= 59) minuty = m; }
	void setSekundy(int s) { if (s >= 0 && s <= 59) sekundy = s; }
	void zeruj() { godziny = minuty = sekundy = 0; }

	// Operatory arytmetyczne
	Czas operator+(const Czas& other) const {
		Czas temp = other;
		temp.sekundy += sekundy;
		temp.minuty += minuty;
		temp.godziny += godziny;
		temp.zabezpiecz();
		return temp;
	}
	Czas& operator+=(const Czas& other) {
		sekundy += other.sekundy;
		minuty += other.minuty;
		godziny += other.godziny;
		zabezpiecz();
		return *this;
	}
	Czas operator/(int num) {
		int total = doSekund();
		total /= num;
		int h = total / 3600;
		total %= 3600;
		int m = total / 60;
		int s = total % 60;
		return Czas(h, m, s);
	}
	Czas& operator/=(int num) {
		Czas temp = (*this) / num;
		*this = temp;
		return *this;
	}

	// Operatory relacyjne
	bool operator<(const Czas& other) {
		return  godziny != other.godziny ?
			godziny < other.godziny :
			minuty != other.minuty ?
			minuty < other.minuty :
			sekundy < other.sekundy;
	}
	bool operator==(const Czas& other) {
		return godziny == other.godziny && minuty == other.minuty && sekundy == other.sekundy;
	}
	bool operator!=(const Czas& other) {
		return !(*this == other);
	}
	bool operator<=(const Czas& other) {
		return *this < other || *this == other;
	}
	bool operator>(const Czas& other) {
		return !(*this <= other);
	}
	bool operator>=(const Czas& other) {
		return !(*this < other);
	}
	bool operator() (Czas &a, Czas &b)
	{
		return (a < b);
	}
};

std::ostream& operator<<(std::ostream& stream, const Czas& c) {
	stream << c.getGodziny() << ":" << c.getMinuty() << ":" << c.getSekundy();
	return stream;
}

//bool myfunction(Czas &a, Czas &b)
//{
//	return(a < b);
//}

int main() {
	int czasy[20];
	czasy[0] = 156;
	czasy[1] = 2173;
	czasy[2] = 580;
	czasy[3] = 12;
	czasy[4] = 9802;
	czasy[5] = 17094;
	czasy[6] = 3007;
	czasy[7] = 8160;
	czasy[8] = 251;
	czasy[9] = 1266;
	czasy[10] = 1417;
	czasy[11] = 2;
	czasy[12] = 1100;
	czasy[13] = 13984;
	czasy[14] = 7140;
	czasy[15] = 9802;
	czasy[16] = 1991;
	czasy[17] = 10057;
	czasy[18] = 5120;
	czasy[19] = 180;

	vector<Czas> wektor;

	for (int i = 0; i < 19; i++)
	{
		wektor.push_back(czasy[i]);

		std::cout << wektor[i] << std::endl;

	}

	std::cout << "pierwsza czesc" << std::endl;

	vector<Czas> nowyWektor;

	Czas czasGraniczny = 1800;

	int j = 0;

	for (int i = 0; i < wektor.size(); i++)
	{
		if (czasGraniczny < czasy[i])
		{
			nowyWektor.push_back(czasy[i]);

			std::cout << nowyWektor.at(j) << std::endl;
			j++;

		}
	}

	std::cout << "druga czesc" << std::endl;

	vector<Czas> jeszczeNowszyWektor(nowyWektor.size());
	
	copy(nowyWektor.begin(), nowyWektor.end(), jeszczeNowszyWektor.begin());

	std::sort(jeszczeNowszyWektor.begin(), jeszczeNowszyWektor.end(), Czas());

	/*for (int i = 0; i < nowyWektor.size(); i++)
	{	
		std::cout << jeszczeNowszyWektor.at(i) << std::endl;
	}*/

	for (std::vector<Czas>::iterator it = jeszczeNowszyWektor.begin(); it != jeszczeNowszyWektor.end(); ++it)
		std::cout << *it << std::endl;

	vector<Czas> najnowszyWektor;

	czasGraniczny = 3600;

	Czas dylatacja = 300;

	std::cout << "zadanie czwarte" << std::endl;

	for (int i = 0; i < nowyWektor.size(); ++i)
	{
		if (nowyWektor.at(i) > czasGraniczny)
		{
			najnowszyWektor.push_back(nowyWektor.at(i));
			najnowszyWektor.push_back(dylatacja);
		}
		else
		{
			najnowszyWektor.push_back(nowyWektor.at(i));
		}
	}

	for (int i = 0; i < najnowszyWektor.size(); i++)
	{
		std::cout << najnowszyWektor.at(i) << std::endl;
	}


	std::cin.get();

	/*
	Dana jest tablica czasów w formie liczby sekund.
	Nale¿y:
	  1. Przetworzyæ j¹ w wektor obiektów klasy Czas
	  2. Utworzyæ nowy wektor, zawieraj¹cy tylko czasy d³u¿sze ni¿ 30 minut
	  3. Utworzyæ kopiê powy¿szego wektora, posortowaæ j¹
	  4. Zmodyfikowaæ wektor z punktu 2, dodaj¹c po ka¿dym czasie d³u¿szym ni¿ 1 godzina "dylatacjê" o d³ugoœci 5 minut.
	Po ka¿dej operacji nale¿y wyœwietlaæ zawartoœæ zmodyfikowanego wektora.
	*/

	return 0;
}