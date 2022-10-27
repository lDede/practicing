using System;
using System.Collections;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E26
    {
        public static Queue CopiaQueue(Queue<Object> origem)
        {
            Queue Q = new Queue();
            foreach (Object elemento in origem)
                Q.Enqueue(elemento);
            return Q;
        }
    }
}
