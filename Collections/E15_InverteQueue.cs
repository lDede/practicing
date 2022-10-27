using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E15
    {
        public static void InverteQueue(Queue Q)
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
