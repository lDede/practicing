//Exercicio03 - Classe
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E3
    {
        public static ArrayList CopiaParteArrayList (ArrayList origem, int inicio, int final)
        {
            ArrayList novoArrayList = new ArrayList();

            if(final > origem.Count)
                final = origem.Count - 1;

            for(int i = inicio; i <= final; i++)
                novoArrayList.Add(origem[i]);

            return novoArrayList;
        }
    }
}
