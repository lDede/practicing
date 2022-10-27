using System;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E24
    {
        public static int QtdeOcorrencias(List<String> origem, String elemento)
        {
            int contar = 0;
            foreach (string value in origem)
                if (value.Equals(elemento)) contar++;
            return contar;
        }
    }
}
