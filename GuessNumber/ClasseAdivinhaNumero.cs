using System;

namespace ProjetoPraticoClasses
{
    public class ClasseAdivinhaNumero
    {
        private bool acerto = false;
        private int numPalpite, numPensado, tentativas;
        private string mensagemProximidade;
        private Random aleatorio = new Random();

        public ClasseAdivinhaNumero()
        {
            numPensado = aleatorio.Next(1, 100);
            acerto = false;
        }

        public bool ConfereAcerto()
        {
            if (numPalpite == numPensado)
            {
                acerto = true;
            }
            return acerto;
        }

        public string GetMensagem()
        {
            SetMensagemProximidade();
            return mensagemProximidade;
        }

        public int GetTentativas()
        {
            return tentativas;
        }

        public void ResetVariaveis()
        {
            numPensado = aleatorio.Next(1, 100);
            tentativas = 0;
            numPalpite = tentativas;
            acerto = false;
            mensagemProximidade = null;
        }

        public void SetPalpite(int palpite)
        {

            numPalpite = palpite;
            tentativas++;
        }

        private void SetMensagemProximidade()
        {
            if (numPalpite > numPensado) mensagemProximidade = "Seu palpite foi MAIOR que o número pensado!";
            else if (numPalpite < numPensado) mensagemProximidade = "Seu palpite foi MENOR que o número pensado!";
            else mensagemProximidade = "\nNúmero descoberto!";
        }
    }
}
