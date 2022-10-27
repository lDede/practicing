using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_LetsMakeAnAED
{
    class CFila
    {
        private CCelula Frente;
        private CCelula Tras;
        private int Qtde;

        /// <summary>
        /// Função construtora. Cria a célula cabeça e faz as referências [...] TODO
        /// </summary>
        public CFila()
        {
            Frente = new CCelula();
            Tras = Frente;
            Qtde = 0;
        }

        public bool Vazia()
        {
            return Frente == Tras;
        }

        public void Enfileira(Object ValorItem)
        {
            Tras.Prox = new CCelula(ValorItem);
            Tras = Tras.Prox;
            Qtde++;
        }
        public Object Desenfileira()
        {
            Object Item = null;
            if(Frente != Tras)
            {
                Frente = Frente.Prox;
                Item = Frente.Item; 
                Qtde--;
            }
            return Item;
        }

        public void MostraFrente()
        {
            Console.WriteLine("{0} ", Frente.Item);
            Console.WriteLine("Quantidade: {0}", Qtde);
        }
    }
}
