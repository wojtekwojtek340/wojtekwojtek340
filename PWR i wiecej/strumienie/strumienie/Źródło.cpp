#include <iostream>
#include <fstream>

int main()
{
	std::ifstream plik;
	int tab[10];
	plik.open("C:\\test.txt",	std::ifstream::in);

	if (plik.is_open())
	{
		int i= 0;

		while(plik.good())
		{
			plik >> tab[i];
			i++;
		}

		for (i = 0; i < 10; i++)
		{
			std::cout << tab[i] << std::endl;
		}

		plik.close();
	}

	else
	{
		std::cout << "BLAD" << std::endl;
	}
	std::cin.get();
	return 0;
}