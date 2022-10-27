using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E16
    {
        public static void InverteStack(Stack origem)
        {
            ArrayList AL = new ArrayList();

            foreach (var elemento in origem)
                AL.Add(elemento);

            origem.Clear();

            for (int i = 0; i <= (AL.Count - 1); i++)
                origem.Push(AL[i]);
        }
    }
}
