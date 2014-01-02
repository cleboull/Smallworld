#pragma once

class Carte
{
public:
	int taille;
	int* map;

	Carte(void);
	Carte(int size);
	~Carte(void);

	void generer();
	int* getData();
};

