#include "api.h"

DLL int* genererMap(int taille){
	Carte c(taille);
	c.generer();
	return c.getData();
}