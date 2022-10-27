using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E14
    {
        public static void VaiProFundo(Stack origem, Object elemento)
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