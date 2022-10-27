using System;
using System.Collections;

namespace AED_LetsMakeAnAED
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Uma célula possui a informação (conteúdo)
             *  E o endereço de memória para este conteúdo.
             */

            /*  The head cell - special!
             *  Entrada para a lista.
             *  ? -> 1st -> 2nd -> 3rd -> ... 10th
             */

            CCelula x = new CCelula("Ye");
            CCelula y = new CCelula("AED");
            CCelula z = new CCelula("ATP");

            CFila fila = new CFila();
            fila.Enfileira(x);
            fila.Enfileira(y);
            fila.Enfileira(z);

            fila.Desenfileira();

            fila.MostraFrente();

            fila.Desenfileira();

            fila.MostraFrente();
            fila.Desenfileira();

            fila.MostraFrente();
            fila.Desenfileira();

            fila.MostraFrente();

            Console.ReadKey();
        }
    }
}