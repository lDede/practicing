using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E12
    {
        public static Queue CopiaQueue(Queue origem)
        {
            Queue destino = new Queue();
            foreach(var elemento in origem)
                destino.Enqueue(elemento);
            return destino;
        }
    }
}
