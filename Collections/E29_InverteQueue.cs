using System.Collections;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E29
    {
        public static void InverteQueue(Queue<object> Q)
        {
            ArrayList AL = new ArrayList();

            foreach (var elemento in Q)
                AL.Add(elemento);

            Q.Clear();

            for (int i = (AL.Count - 1); i >= 0; i--)
                Q.Enqueue(AL[i]);
        }
    }
}
