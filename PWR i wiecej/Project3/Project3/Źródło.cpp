#include <iostream>
#include <string>

using namespace std;

int main()
{
	string kod;
	int liczba[12];

	while (true)
	{
		cout << "Podaj liczbe w kodzie graya:" << endl;
		std::cin >> kod;
		cout << endl;

		for (int i = 0; i < 12; i++)
		{
			string bufor;
			liczba[i] = kod.at(i);
			bufor = liczba[i];
			liczba[i] = stoi(bufor);
		}
		int gray[12];

		for (int i = 0; i < 12; i++)
		{
			if (i == 0)
			{
				gray[i] = liczba[i];
			}
			else
			{
				gray[i] = gray[i - 1] ^ liczba[i];
			}
		}

		cout << "Liczba w kodzie gray" << endl << endl;

		for (int i = 0; i < 12; i++)
		{
			cout << gray[i];
		}

		
		cin.get();
		cin.get();

		system("cls");
	}	
}