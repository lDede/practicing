using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab_HashAndTrees.Andrew
{
    class ListaRef
    {
        private Celula primeira;
        private Celula ultima;
        public ListaRef()
        {
            primeira = new Celula();
            ultima = primeira;
        }
        public bool vazia()
        {
            if (primeira == ultima)
                return true;
            else
                return false;
        }
        public void insereFim(Object valorItem)
        {
            Celula novoElemento = new Celula();
            novoElemento.item = (int)valorItem;
            if (vazia())
            {
                primeira.prox = novoElemento;
                ultima = primeira.prox;
                ultima.prox = null;
            }
            else
            {
                ultima.prox = novoElemento;
                ultima = ultima.prox;
                ultima.prox = null;
            }
        }
        public int pesquisa(Object elemento)
        {
            Celula percorre = primeira;
            bool found = false;
            while(percorre.prox != null && !found)
            {
                if (percorre.prox.item.Equals((int)elemento))
                    found = true;
                else
                    percorre = percorre.prox;
            }
            if (found)
                return 01;
            return -01;
        }
        public int retira(Object chave)
        {
            Celula percorre = primeira;
            bool found = false;
            int itemToReturn = 0;
            while(percorre != null && !found)
            {
                if (percorre.prox.item.Equals((int)chave))
                {
                    found = true;
                    itemToReturn = percorre.prox.item;
                }
                else
                    percorre = percorre.prox;
            }
            if (found) { 
                if(percorre.prox.prox == null)
                {
                    ultima = percorre;
                    ultima.prox = null;
                }
                else
                {
                    percorre.prox = percorre.prox.prox;
                }
                return itemToReturn;
            }
            return -1;
        }
        public void imprime()
        {
            Celula percorre = primeira;
            Console.Write("[");
            while (percorre.prox != null)
            {
                Console.Write(percorre.prox.item + ", ");
                percorre = percorre.prox;
            }
            Console.Write("]\n");
        }
    }
}
