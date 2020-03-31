#pragma once

class Cylinder
{
protected:
	const double pi;
	double promien;
	double wysokosc;
public:
	Cylinder(double _r, double _h);
	double obliczPolePodstawy();
	double obliczObjetosc();
};
