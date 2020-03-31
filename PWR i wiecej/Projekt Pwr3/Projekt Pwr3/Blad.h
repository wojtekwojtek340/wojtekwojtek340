#pragma once
#include <string>
#include <iostream>
#include <exception>



using std::string;

class Blad : public std::exception
{
private:
	string kodBledu;
public:
	Blad(const char* wiadomosc)
		:kodBledu(wiadomosc)
	{}
	Blad(const string& wiadomosc)
		:kodBledu(wiadomosc)
	{}
	const char* what()
	{
		return kodBledu.c_str();
	}
};