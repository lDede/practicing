using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E5
    {
        public static void ApagaArrayList2(ArrayList origem, int inicio, int qtde)
        {
            int final = inicio + qtde;

            if(origem.Count < final)
                final = origem.Count;

            for(int i = inicio; i < final; i++)
                origem.Remove(i);
        }
    }
}