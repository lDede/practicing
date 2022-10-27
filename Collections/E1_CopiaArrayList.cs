//Exercício01 - Classe
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E1
    {
        public static ArrayList CopiaArrayList(ArrayList origem)
        {
            ArrayList novoArrayList = new ArrayList();
            foreach(object value in origem)
                novoArrayList.Add(value);            
            return novoArrayList;
        }
    }
}
