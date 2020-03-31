// strc_ref.cpp -- u�ycie referencji do struktur
#include <iostream>
#include <string>

struct free_throws
{
	std::string name;
	int made;
	int attempts;
	float percent;
};

void display(const free_throws & ft);
void set_pc(free_throws & ft);
free_throws & accumulate(free_throws & target, const free_throws & source);

int main()
{
	// inicjalizacje cz�ciowe -- reszta sk�adowych jest zerowana
	free_throws one = { "Ifelsa Branch", 13, 14 };
	free_throws two = { "Andor Knott", 10, 16 };
	free_throws three = { "Minnie Max", 7, 9 };
	free_throws four = { "Whily Looper", 5, 9 };
	free_throws five = { "Long Long", 6, 14 };
	free_throws team = { "Throwgoods", 0, 0 };
	// bez inicjalizacji
	free_throws dup;

	set_pc(one);
	display(one);
	accumulate(team, one);
	display(team);

	// warto�ci zwracane u�yjemy w roli argument�w wywo�ania
	display(accumulate(team, two));
	accumulate(accumulate(team, three), four);
	display(team);

	// warto�ci zwracane u�yte w przypisaniach:
	dup = accumulate(team, five);
	std::cout << "Statystyka dla team:\n";
	display(team);
	std::cout << "Statystyka dla dup po przypisaniu:\n";
	display(dup);
	set_pc(four);

	// �le skonstruowane przypisanie
	accumulate(dup, five) = four;
	std::cout << "Statystyka dla dup po omy�kowym przypisaniu:\n";
	display(dup);
	return 0;
}
void display(const free_throws & ft)
{
	using std::cout;
	cout << "Imi�: " << ft.name << '\n';
	cout << "Trafionych: " << ft.made << '\t';
	cout << "Rzut�w: " << ft.attempts << '\t';
	cout << "Skuteczno��: " << ft.percent << '\n';
}
void set_pc(free_throws & ft)
{
	if (ft.attempts != 0)
		ft.percent = 100.0f *float(ft.made) / float(ft.attempts);
	else
		ft.percent = 0;
}
free_throws & accumulate(free_throws & target, const free_throws & source)
{
	target.attempts += source.attempts;
	target.made += source.made;
	set_pc(target);
	return target;
}
