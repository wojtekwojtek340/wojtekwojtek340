#include <iostream>

class Bron {
protected:
	int wytrzymalosc;
public:
	Bron() : wytrzymalosc(100) {}
	int getWytrzymalosc() { return wytrzymalosc; }
	virtual float getObrazenia() {
		std::cout << "Zwykla bron: ?" << std::endl;
		return 0;
	}

	void uszkodzenie()
	{
		wytrzymalosc -= 1;
	}

	float atak()
	{
		getObrazenia();
		uszkodzenie();
		std::cout << "wytrzymalosc: " << wytrzymalosc << std::endl;
		return 0;
	}
};

class Miecz : public Bron {
public:
	float getObrazenia() {
		std::cout << "Miecz: 31-35" << std::endl;
		return 33;
	}
};

class Luk : public Bron {
public:
	float getObrazenia() {
		std::cout << "Luk = 10-68" << std::endl;
		return 39;
	}

	void uszkodzenie()
	{

	}
};

// #include "Bron.h" // nie trzeba juz znac wszystkich mozliwych broni,
// wystarczy znajomosc najbardziej ogolnego typu
class Gracz {
	Bron* bron;                     // polimorficzny "uchwyt" na bron - jeden pasuje do wszystkich
public:
	Gracz() : bron(nullptr) {}

	void setBron(Bron* _bron) {
		bron = _bron;               // niewazne jaka bron zostanie przekazana przez argument,
	}                               // na pewno bedzie dziedziczyla po klasie bazowej Bron

	void atak() {                   // jedna metoda "atak", niewazne jaka bron jest aktywna -
		if (bron)                   // wiadomo, ze kazda z nich ma metode getObrazenia, wiec
			bron->atak();   // zawsze bedzie mozna ja wywolac
	}
};

int main() {
	Miecz dziadek;
	dziadek.getObrazenia();         // pokaz obrazenia samego miecza

	Gracz paladyn;
	paladyn.setBron(&dziadek);      // polimorficzne przekazanie
	paladyn.atak();                 // gracz polimorficznie uzywa broni,
									// choc nie zna jej konkretnego typu
	std::cin.get();
	return 0;
}