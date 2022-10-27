using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLab_HashAndTrees.Andrew
{
    class NoArvoreBinaria
    {
        public NoArvoreBinaria topo;
        public NoArvoreBinaria esquerda;
        public NoArvoreBinaria direita;
        public int fatorBalanceamento;
        public int item;
        public NoArvoreBinaria()
        {
            topo = null;
            esquerda = null;
            direita = null;
            item = 0;
        }
        public NoArvoreBinaria(int elemento)
        {
            topo = null;
            esquerda = null;
            direita = null;
            item = elemento;
        }
        public NoArvoreBinaria(NoArvoreBinaria topoParam, NoArvoreBinaria esquerdaParam, NoArvoreBinaria direitaParam, int elemento)
        {
            topo = topoParam;
            esquerda = esquerdaParam;
            direita = direitaParam;
            item = elemento;
        }
    }
}
