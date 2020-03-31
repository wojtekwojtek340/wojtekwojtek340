#include <iostream>
#include "Menu.h"
#include <time.h>
#include "Lochy.h"
#include "Gracz.h"

int main()
{
	srand(time(NULL));
	Menu menuGlowne;
	Lochy loch;
	Gracz gracz;
	menuGlowne.wypiszNaKonsole("Witaj w symulatorze postaci!", 500);
	menuGlowne.menu1(gracz, loch);
	return 0;
}