using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Exercício 01/05
 */

namespace AEDLab_Aula01
{
    public class Exercicio01
    {
        public static void ImprimeVetor(sbyte[] vetor)
        {
            Console.Write("[");
            for (byte indice = 0; indice < vetor.Length; indice++)
            {
                Console.Write(vetor[indice]);
                Console.Write(", ");
            } // fim for loop
            Console.Write("]");
            Console.Write("\n");
        }
        private static void VerificaNumeros(sbyte[] vetor)
        {
            for (byte indice = 0; indice < vetor.Length; indice++)
            {
                // Início de repetição para coletar um número válido para o vetor entre 0 e 127.
                // Enquanto a variável monitoraErro permanecer verdadeira, um número será solicitado para preencher a posição atual do vetor.
                
                bool monitoraErro = true;
                sbyte numero = 0;
                do
                {
                    indice++;
                    Console.Write("Número {0} de {1}\n", indice, vetor.Length);
                    Console.Write("Digite um número inteiro e positivo entre 0 e 127: ");
                    try
                    {
                        numero = sbyte.Parse(Console.ReadLine());
                        if (numero < 0)
                        {
                            Console.WriteLine("O número não pode ser negativo!");
                        }
                        else if (numero >= 0 && numero <= sbyte.MaxValue)
                        {
                            monitoraErro = false;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    } // fim try
                    catch (OverflowException)
                    {
                        Console.WriteLine("O valor digitado está fora dos limites. Por favor, tente novamente.");
                    } // fim catch 1
                    catch
                    {
                        Console.WriteLine("Erro!");
                        Console.WriteLine("O valor digitado possui caracteres de texto ou especiais.");
                    } // fim catch 1
                    indice--;
                } while (monitoraErro); // fim do-while
                vetor[indice] = numero;
            } // fim loop for
        }
        public static void Run()
        {
            // cria vetor com 
            sbyte[] vetorInteiros = new sbyte[10];

            VerificaNumeros(vetorInteiros);

            ImprimeVetor(vetorInteiros);

            // Verifica o elemento da sexta posição para ser eliminado (número 5) e atribui -10 ao último elemento
            for (byte indice = 5; indice < vetorInteiros.Length; indice++)
            {
                if (indice != 9)
                {
                    sbyte nextElemento = vetorInteiros[++indice];
                    vetorInteiros[--indice] = nextElemento;
                }
                else vetorInteiros[indice] = -10;
                
            } // fim for loop

            ImprimeVetor(vetorInteiros);
        }
    }
}
