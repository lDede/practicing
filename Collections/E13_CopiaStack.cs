using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E13
    {
        public static Stack CopiaStack(Stack origem)
        {
            ArrayList AL = new ArrayList();

            foreach (var elemento in origem)
                AL.Add(elemento);

            Stack S = new Stack();

            for (int i = (AL.Count-1); i >= 0; i--)
                S.Push(AL[i]);

            return S;
        }
    }
}
