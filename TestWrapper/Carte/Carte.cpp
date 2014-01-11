#include "Carte.h"
#include <stdlib.h>     /* srand, rand */
#include <time.h> 

Carte::Carte(void):taille(2){
}

Carte::Carte(int size):taille(size){
}

Carte::~Carte(void){
}

/*Génére une liste d'entier représentant le type de la case
0 -> Desert
1 -> Foret
2 -> Montagne
3 -> Plaine
4 -> Mer
*/
void Carte::generer(){
	int i;
	map = new int [taille*taille];
	srand (time(NULL));

	for(i=0;i<taille*taille;i++)
		map[i] = rand() % 5;
}

int* Carte::getData(){
	return map;
}