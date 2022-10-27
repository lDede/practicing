using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E10
    {
        public static ArrayList OcorrenciasDe(ArrayList AL, Object elemento)
        {
            ArrayList elementsPositions = new ArrayList();
            for(int i = 0; i < AL.Count; i++)
                if(AL[i].Equals(elemento))
                    elementsPositions.Add(i);
            return elementsPositions;
        }
    }
}
