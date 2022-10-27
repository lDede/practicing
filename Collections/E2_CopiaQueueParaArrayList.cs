//Exercício02 - Classe
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E2
    {
        public static ArrayList CopiaQueueParaArrayList(Queue origem)
        {
            ArrayList queueParaArrayList = new ArrayList();
            foreach (var elemento in origem)
                queueParaArrayList.Add(elemento);
            return queueParaArrayList;
        }
    }
}
