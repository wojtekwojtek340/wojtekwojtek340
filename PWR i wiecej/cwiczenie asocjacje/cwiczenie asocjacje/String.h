#pragma once

class String
{
private:
	int rozmiar;
	char *tab;
public:
	char* zawartosc();
	String();
	String(const char *_src);
	String(const String &_zrodlo);
	String& operator=(const String &_zrodlo);
	~String();
};