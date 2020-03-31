#include "Cylinder.h"

Cylinder::Cylinder(double _r, double _h) :
	pi(3.141592), promien(_r), wysokosc(_h)
{
}
double Cylinder::obliczPolePodstawy()
{
	return pi * promien*promien;
}
double Cylinder::obliczObjetosc()
{
	return wysokosc * obliczPolePodstawy();
}