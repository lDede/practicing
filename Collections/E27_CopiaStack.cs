using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E27
    {
        public static Stack<object> CopiaStack(Stack<object> origem)
        {
            Stack<object> pilha = new Stack<object>();

            object[] aux = new object[origem.Count];

            for(int i = 0; i < aux.Length; i++)
                aux[i] = origem.Pop();

            for(int i = (aux.Length -1); i >= 0; i--)
                pilha.Push(aux[i]);

            return pilha;
        }
    }
}
