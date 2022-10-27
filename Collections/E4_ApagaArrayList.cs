using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E4
    {
        public static void ApagaArrayList(ArrayList origem, int inicio, int final)
        {
            if (final > origem.Count)
                final = origem.Count - 1;
            
            for(int i = (inicio + 1); i < final; i++)
                origem.Remove(i);
        }
    }
}
