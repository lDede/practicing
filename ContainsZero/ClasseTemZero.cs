using System;

namespace ProjetoPraticoClasses
{
    public class ClasseTemZero
    {
        private int numero, contaZeros;
        public void SetNumero(int numeroParam)
        {
            numero = numeroParam;
        }
        public void VerificaZero()
        {
            string numeroTexto = numero.ToString();
            for (int posicao = 0; posicao < numeroTexto.Length; posicao++)
            {
                if (numeroTexto[posicao] == '0')
                {
                    contaZeros++;
                }
            }
            ImprimeTela();
        }
        private void ImprimeTela()
        {
            if (contaZeros > 0)
            {
                if (contaZeros == 1) Console.WriteLine("O número {0} contém {1} zero.", numero, contaZeros);
                else Console.WriteLine("O número {0} contém {1} zeros.", numero, contaZeros);
            }
            else
            {
                Console.WriteLine("O número {0} não contém zeros!", numero);
            }
        }
        public void ResetVariaveis()
        {
            numero = contaZeros = 0;
        }
    }
}
