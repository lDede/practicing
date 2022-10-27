using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E7
    {
        public static void ConcatecaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3)
        {
            foreach(var element in AL1)
                AL3.Add(element);
            foreach(var element in AL2)
                AL3.Add(element);
        }
    }
}
