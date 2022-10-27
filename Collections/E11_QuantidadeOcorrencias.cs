using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E11
    {
        public static int QtdeOcorrencias(ArrayList AL, Object elemento)
        {
            int contar = 0;
            for (int i = 0; i < AL.Count; i++)
                if (AL[i].Equals(elemento))
                    contar++;
            return contar;
        }
    }
}
