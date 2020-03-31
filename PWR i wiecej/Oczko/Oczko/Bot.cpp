#include "Bot.h"
#pragma warning(disable : 4996)

char imiona[][20] = { "Bot1", "Bot2", "Bot3", "Bot4", "Bot5", "Bot6" };

void Bot::nadajNazweBota(int _a)
{
	strcpy(nazwa, imiona[_a]);
}