#pragma once
#include "Carte.h"

#ifdef DLL_EXPORTS
	#define DLL __declspec(dllexport)
	#define EXTERNC extern "C"
#else
	#define DLL __declspec(dllimport)
	#define EXTERNC
#endif

EXTERNC DLL int* genererMap(int taille);
EXTERNC DLL int* getPositionInit(int* map,int tailleMap);