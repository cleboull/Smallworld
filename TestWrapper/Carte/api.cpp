#include "api.h"
#include <math.h>
DLL int* genererMap(int taille){
	Carte c(taille);
	c.generer();
	return c.getData();
}

DLL int* getPositionInit(int* map,int tailleMap){
	int tailleCote = (int)sqrt((double)tailleMap);
	int posJ1;
	int posJ2;
	int pos1;
	int pos2;
	int i,j,k,l;
	double distanceMax=0;
	double distance;
	for(i=0;i<3;i++){
		for(j=0;j<3;j++){
			pos1 = j*tailleCote+i;
			if(map[pos1]!=4){ //si la case n'est pas de type eau
				for(k=tailleCote;k>tailleCote-3;k--){
					for(l=tailleCote;l<tailleCote-3;l--){
						pos2 = l*tailleCote+k;
						if(map[pos2]!=4){
							distance = sqrt((double)((k-i)*(k-i)+(l-j)*(l-k)));
							if(distance>distanceMax){
								posJ1=pos1;
								posJ2=pos2;
							}
						}
					}
				}
			}
		}
	}
	return new int[posJ1,posJ2];
}