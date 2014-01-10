#pragma once
#include "Carte.h"

#ifdef DLL_EXPORTS
	#define DLL __declspec(dllexport)
#else
	#define DLL __declspec(dllimport)
#endif

extern "C" 
{
	DLL int* genererMap(int taille);
	DLL int* getPositionInit(int* map,int tailleMap);
}