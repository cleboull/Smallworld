#include "Carte.h"
#include <stdlib.h>     /* srand, rand */
#include <time.h> 

Carte::Carte(void):taille(2){
}

Carte::Carte(int size):taille(size){
}

Carte::~Carte(void){
}

void Carte::generer(){
	int i;
	map = new int [taille*taille];
	srand (time(NULL));
	for(i=0;i<taille*taille;i++)
		map[i] = rand() % 4;
}

int* Carte::getData(){
	return map;
}