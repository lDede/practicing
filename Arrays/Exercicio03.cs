using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Exercício 03/05
 */

namespace AEDLab_Aula01
{
    class Exercicio03
    {
        public static void Run()
        {
            int[,] numerosInteiros = new int[7, 7];
            int somaLinha5 = 0;
            int somaColuna4 = 0;
            int somaElementosMatriz = 0;
            Random random = new Random();

            for (byte linha = 0; linha < numerosInteiros.GetLength(0); linha++)
            {
                Console.Write("\n");
                Console.Write("{0}[", linha);
                for (byte coluna = 0; coluna < numerosInteiros.GetLength(1); coluna++)
                {
                    numerosInteiros[linha, coluna] = random.Next(0, 10); // aleatório entre 0 e 9
                    Console.Write("{0}, ", numerosInteiros[linha, coluna]); //exibe o número aleatório guardado na posição do vetor
                    somaElementosMatriz += numerosInteiros[linha, coluna];  //soma o número aleatório guardado ao montante da soma dos elementos da matriz 7x7
                    if (linha == 5)
                    {
                        // caso a linha seja a quinta, soma os elementos das colunas da linha 5
                        somaLinha5 += numerosInteiros[5, coluna];
                    }
                    if (coluna == 4)
                    {
                        // caso a coluna seja a quarta, soma os elementos das linhas da coluna 4
                        somaColuna4 += numerosInteiros[linha, 4];
                    }
                }
                Console.Write("]");
            }
            Console.WriteLine("\nSoma da Linha 5: {0}", somaLinha5);
            Console.WriteLine("Soma da Coluna 4: {0}", somaColuna4);
            Console.WriteLine("Soma de todos os elementos da matriz: {0}", somaElementosMatriz);
        }
    }
}
