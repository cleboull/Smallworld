// mWrapper.h

#include "api.h"

using namespace System;
using namespace System::Collections::Generic;

namespace mWrapper {

	public ref class WrapperMap
	{
	public:
		List<int> ^ CreateMapWrapper(int taille){
			int i;
			List<int> ^ myMap = gcnew List<int>();
			int * tmp = genererMap(taille);
			for(i=0;i<=taille*taille;i++)
				myMap->Add(tmp[i]);
			return myMap;
		}
	};
}
