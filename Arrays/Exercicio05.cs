using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Exercício 05/05
 */

namespace AEDLab_Aula01
{
    class Exercicio05
    {
        public static void Run()
        {
            int[,] matriz = new int[10, 10];
            int[] somaColunas = new int[matriz.GetLength(1)];
            int totalDosElementos = 0;
            int pulaParaProximaColuna = 0;

            for (byte linha = 0; linha < matriz.GetLength(0); linha++)
            {
                Console.Write("[");
                for (byte coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (linha != coluna) // se a linha for diferente da coluna, verifica condições
                    {
                        if (linha < coluna) matriz[linha, coluna] = coluna + linha;
                        else matriz[linha, coluna] = -1;
                    }
                    else
                    {
                        // linha e coluna na mesma posição, atribui-se 1
                        matriz[linha, coluna] = 1;
                    }
                    Console.Write("{0}, ", matriz[linha, coluna]);
                } // fim for coluna
                Console.Write("]\n");
            } // fim for linha


            while (pulaParaProximaColuna < matriz.GetLength(1))
            {
                // enquanto a proxima coluna for menor que o tamanho das colunas, executa:
                for (byte linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    //soma as linahs correpondenets às colunas
                    somaColunas[pulaParaProximaColuna] += matriz[linha, pulaParaProximaColuna];
                }
                Console.WriteLine("Soma da coluna {0}: {1}", pulaParaProximaColuna, somaColunas[pulaParaProximaColuna]);
                pulaParaProximaColuna++;
            } // fim while

            // para cada elemento nas soma das colunas individuais, soma ao total para exibir ao usuário
            foreach (int elementos in somaColunas)
            {
                totalDosElementos += elementos;
            }

            Console.WriteLine("Soma total dos elementos da matriz: {0}", totalDosElementos);

        }
    }
}
