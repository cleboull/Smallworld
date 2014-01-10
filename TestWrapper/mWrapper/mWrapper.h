// mWrapper.h
#pragma once
#include "api.h"
#pragma comment (lib, "Carte.lib")
using namespace System;
using namespace System::Collections::Generic;


//comm mWrapper
namespace mWrapper {

	public ref class WrapperMap
	{
	public:
		List<int> ^ CreateMapWrapper(int taille){
			int i;
			List<int> ^ myMap = gcnew List<int>();
			int * tmp = genererMap(taille);
			for(i=0;i<taille*taille;i++)
				myMap->Add(tmp[i]);
			return myMap;
		}

		List<int> ^ GetPositionInit(List<int> map){
			int * mapC;
			int i;
			int tailleMap = map.Count;
			for (i=0;i<tailleMap;i++){
				mapC[i]=map[i];
			}
			
			int * tmp = getPositionInit(mapC,tailleMap);
			List<int> ^ positions = gcnew List<int>();
			positions[0]=tmp[0];
			positions[1]=tmp[1];
			return positions;
		}
	};
}