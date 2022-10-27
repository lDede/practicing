using System.Collections;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E28
    {
        public static void VaiProFundo(Stack<object> origem, object elemento)
        {
            ArrayList AL = new ArrayList();

            foreach (var value in origem)
                AL.Add(value);

            origem.Clear();
            AL.Add(elemento);

            for (int i = (AL.Count - 1); i >= 0; i--)
                origem.Push(AL[i]);
        }
    }
}
