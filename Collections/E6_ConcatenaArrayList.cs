//
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E6
    {
        public static ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2)
        {
            ArrayList AUB = new ArrayList();
            foreach(var elemento in AL1)
                AUB.Add(elemento);
            foreach(var elemento in AL2)
                AUB.Add(elemento);
            return AUB;
        }
    }
}
