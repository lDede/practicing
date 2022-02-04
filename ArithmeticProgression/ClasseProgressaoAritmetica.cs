using System;

namespace ProjetoPraticoClasses
{
    public class ClasseProgressaoAritmetica
    {
        private int constante, somaPA, numeroTermos, saltaTermos;

        private void SetPA()
        {
            constante = 3;
            somaPA = 1;
        }
        private void CalculaSaltaTermos()
        {
            while (numeroTermos > 0)
            {
                if (saltaTermos <= 0)
                {
                    Console.Write(" {0},", somaPA);
                }
                somaPA += constante;
                saltaTermos--;
                numeroTermos--;
            }
        }

        public void SetQuantidadeTermos(int numero)
        {
            numeroTermos = numero;
        }

        public void SetSaltaTermos(int numero)
        {
            saltaTermos = numero;
        }

        public void GetPA()
        {
            SetPA();
            Console.Write("S = {");
            CalculaSaltaTermos();
            Console.Write(" ...}\n");
        }
    }
}
