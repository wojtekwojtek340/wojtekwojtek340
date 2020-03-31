#pragma once

template <typename T>
class Para {
	T* argument1;
	T* argument2;
public:
	Para()
	{
		argument1 = new T;
		argument2 = new T;
	}
	~Para()
	{
		delete argument1;
		delete argument2;
	}
	
};
