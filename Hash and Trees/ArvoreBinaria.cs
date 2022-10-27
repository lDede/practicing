using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab_HashAndTrees.Andrew
{
    class ArvoreBinaria
    {
        private NoArvoreBinaria raiz;
        private int quantidadeElementos;
        public ArvoreBinaria(int item)
        {
            raiz = new NoArvoreBinaria(item);
            quantidadeElementos = 1;
        }
        public bool verificaSeFolha(NoArvoreBinaria no)
        {
            if (no.esquerda == null && no.direita == null)
                return true;
            return false;
        }
        public void imprimir()
        {
            imprimeArvore(raiz);
        }
        private void imprimeArvore(NoArvoreBinaria noAtual)
        {
            if (noAtual.esquerda != null)
            {
                imprimeArvore(noAtual.esquerda);
            }

            Console.Write(noAtual.item + " ");

            if (noAtual.direita != null)
            {
                imprimeArvore(noAtual.direita);
            }
        }
        public void inserirElemento(int valorItem)
        {
            if (quantidadeElementos >= 2)
            {
                NoArvoreBinaria percorre = raiz;
                bool elementoRepetido = false;
                bool saiDoLoop = false;
                while (!verificaSeFolha(percorre) && !elementoRepetido && !saiDoLoop)
                {
                    if (valorItem < percorre.item)
                    {
                        if (percorre.esquerda != null)
                            percorre = percorre.esquerda;
                        else
                            saiDoLoop = true;
                    }
                    else if (valorItem > percorre.item)
                    {
                        if (percorre.direita != null)
                            percorre = percorre.direita;
                        else
                            saiDoLoop = true;
                    }
                    else
                        elementoRepetido = true;
                }

                if (!elementoRepetido)
                {
                    NoArvoreBinaria novoElemento = new NoArvoreBinaria(valorItem);

                    if (valorItem < percorre.item)
                        percorre.esquerda = novoElemento;
                    else
                        percorre.direita = novoElemento;

                    novoElemento.topo = percorre;

                    quantidadeElementos++;
                }
            }
            else
            {
                if (!raiz.item.Equals(valorItem))
                {
                    NoArvoreBinaria novoElemento = new NoArvoreBinaria(valorItem);
                    if (valorItem < raiz.item) raiz.esquerda = novoElemento;
                    else raiz.direita = novoElemento;
                    novoElemento.topo = raiz;
                    quantidadeElementos++;
                }
            }
        }
    }
}
