using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{

    class E8
    {
        public static ArrayList Intersecao(ArrayList AL1, ArrayList AL2)
        {
            ArrayList InterSec = new ArrayList();

            for (int linha = 0; linha < AL1.Count; linha++)
                for (int coluna = 0; coluna < AL2.Count; coluna++)
                    if (AL1[linha].Equals(AL2[coluna]))
                        if (InterSec.BinarySearch(AL1[linha]) < 0)
                            InterSec.Add(AL1[linha]);

            return InterSec;
        }

        public static ArrayList Uniao(ArrayList AL1, ArrayList AL2)
        {
            ArrayList Union = new ArrayList();
            foreach (var element in AL1)
                Union.Add(element);
            foreach (var element in AL2)
                if(!Union.Contains(element))
                    Union.Add(element);
            return Union;
        }
    }
}
