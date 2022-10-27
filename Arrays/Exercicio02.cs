using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Exercício 02/05
 */

namespace AEDLab_Aula01
{
    class Exercicio02
    {
        private static int[] DeterminaQuantidadeElementosVetor(int[] vetor, byte tamanho)
        {
            do
            {
                Console.Write("Digite a quantidade de números que deseja armazenar no vetor: ");
                tamanho = 0;
                try
                {
                    tamanho = byte.Parse(Console.ReadLine());
                    if (tamanho >= (byte.MinValue + 2) && tamanho <= byte.MaxValue) break; //Se o tamanho digitado for maior que 2 e menor ou igual a 255, interompe o do-while.
                    else Console.WriteLine("Por favor, digite um valor entre 2 e 255");
                } //fimtry
                catch
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Existem caracteres de texto ou especiais, tente novamente.");
                } //fim catch
            } while (tamanho < 2 || tamanho > byte.MaxValue); // condição do-while

            vetor = new int[tamanho]; // atribui novo tamanho
            return vetor;
        }

        private static void PreencheVetor(int[] vetor)
        {
            for (byte indice = 0; indice < vetor.Length; indice++)
            {
                int novoNumero = 0;
                try
                {
                    indice++;
                    Console.Write("Número {0} de {1}\n", indice, vetor.Length);
                    indice--;
                    Console.Write("Digite um número inteiro e positivo: ");
                    novoNumero = int.Parse(Console.ReadLine());
                    if (novoNumero >= int.MinValue && novoNumero <= int.MaxValue) vetor[indice] = novoNumero; //permite guardar um número no vetor se for um número dentro dos limites mínimos e máximos dos inteiros
                    else throw new Exception();
                } // fim try
                catch (OverflowException)
                {
                    Console.WriteLine("O número digitado excede o tamanho suportado. Por favor, tente novamente");
                    indice--;
                } // fim catch 1
                catch
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Existem caracteres de texto ou especiais, tente novamente.");
                    indice--;
                } // fim catch 2
            } // fim for
        }

        private static void ImprimeVetor(int[] vetor)
        {
            Console.Write("[ ");
            for (byte indice = 0; indice < vetor.Length; indice++)
            {
                Console.Write("{0}, ", vetor[indice]);
            }
            Console.Write("]");
        }

        private static void VerificaMaiorDiferenca(int[] vetor)
        {
            // elementoA e elementoB são os elementos que serão comparados para determinar as diferenças
            int elementoA = int.MinValue;
            int elementoB = int.MaxValue;
            int maiorDiferença = int.MinValue;
            int[] vetorGuardaElementos = new int[2];

            for (byte indice = 0; indice < (vetor.Length - 1); indice++)
            {
                elementoA = vetor[indice];
                // aumenta o índice para coletar o próximo
                indice++;

                elementoB = vetor[indice];

                //diminui o índice para voltar ao anterior
                indice--;
                int diference = Math.Abs(elementoA - elementoB);
                if (maiorDiferença < diference)
                {
                    // guarda elementos que foram comparados para exibição
                    vetorGuardaElementos[0] = elementoA;
                    vetorGuardaElementos[1] = elementoB;
                    maiorDiferença = diference;
                }
            }
            Console.WriteLine("A maior diferença foi de {0} entre os elementos {1} e {2}!", maiorDiferença, vetorGuardaElementos[0], vetorGuardaElementos[1]);
        }
        public static void Run()
        {
            int[] vetorInteiros = new int[0];
            byte quantidadeElementos = 0; // de 2 a 255 posições;

            vetorInteiros = DeterminaQuantidadeElementosVetor(vetorInteiros, quantidadeElementos);

            PreencheVetor(vetorInteiros);

            ImprimeVetor(vetorInteiros);

            VerificaMaiorDiferenca(vetorInteiros);
        }
    }
}
