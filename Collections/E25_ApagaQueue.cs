using System;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E25
    {
        public static void ApagaQueue(Queue<int> origem, int inicio, int final)
        {
            if(inicio < origem.Count)
            {
                if (origem.Count < final) final = origem.Count;

                int[] aux = new int[origem.Count];                
                for (int i = 0; i < aux.Length; i++)
                    aux[i] = origem.Dequeue();

                origem.Clear();

                for(int i = 0; i < aux.Length; i++)
                    if(!(i >= (inicio+1) && i <= (final-1)))
                        origem.Enqueue(aux[i]);
            }
            else
            {
                Console.WriteLine("O valor especificado para início não pode ser menor que o tamanho da Fila.");
            }
        }
    }
}
