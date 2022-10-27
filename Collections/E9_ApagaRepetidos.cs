using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E9
    {
        public static void ApagaRepetidos(ArrayList AL)
        {
            int repeat = 0;
            for (int i = 0; i < AL.Count; i++, repeat = 0)
                for (int j = 0; j < AL.Count; j++)
                    if (AL[i].Equals(AL[j]))
                    {
                        repeat++;
                        if (repeat >= 2)
                            AL.RemoveAt(j);
                    }
        }
    }
}
