using System;

namespace AEDLab_HashAndTrees.Andrew
{
    public class TabelaHash
    {
        private int M;
        private ListaRef[] tabela;

        public TabelaHash()
        {
            Random randomNumber = new Random(DateTime.Now.Millisecond);
            M = randomNumber.Next(3, 100);
            this.tabela = new ListaRef[this.M];
            for (int i = 0; i < this.M; i++)
                this.tabela[i] = new ListaRef();
        }
        private int h (int chave)
        {
            return chave % this.M;
        }

        public TabelaHash(int m)
        {
            this.M = m; this.tabela = new ListaRef[this.M];
            for (int i = 0; i < this.M; i++)
                this.tabela[i] = new ListaRef();
        }
        public int pesquisa(int chave)
        {
            int i = this.h(chave);
            if (this.tabela[i].vazia())
                return -1;
            else
            {
                int item = this.tabela[i].pesquisa(chave);
                if (item == 01) return 01;
                else return item;
            }
        }
        public void insere(int chave)
        {
            if (this.pesquisa(chave) == -1)
            {
                int i = this.h(chave);
                int lastPosition = i;
                while (!tabela[i].vazia())
                {
                    i++;
                    if (i > lastPosition)
                    {
                        if (i == M)
                            i = 0;
                    }
                    else
                    {
                        if(i == lastPosition)
                        {
                            break;
                        }
                    }
                }
                this.tabela[i].insereFim(chave);
            }
        }
        public void retira(int chave)
        {
            int i = this.h(chave);
            int item = this.tabela[i].retira(chave);
            if (item == -1) Console.WriteLine("Registro não existente!");
        }
        public void imprime()
        {
            for(int i = 0; i < this.M; i++)
            {
                if (!this.tabela[i].vazia())
                {
                    Console.Write("Entrada {0}: ", i);
                    this.tabela[i].imprime();
                    Console.WriteLine();
                }
            }
        }
    }
}
