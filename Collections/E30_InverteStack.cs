using System.Collections;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E30
    {
        public static void InverteStack(Stack<object> origem)
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
