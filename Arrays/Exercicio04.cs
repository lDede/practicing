using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Exercício 04/05
 */

namespace AEDLab_Aula01
{
    class Exercicio04
    {
        public static void Run()
        {
            Random random = new Random();
            bool iguais = true;
            // Cria matrizes com tamanhos aleatórios entre 1 e 2 elementos (para aumentar a possiblidade de dar certo
            int[,] matrizA = new int[random.Next(1, 2), random.Next(1, 2)];
            int[,] matrizB = new int[random.Next(1, 2), random.Next(1, 2)];

            // Para duas matrizes ser idênticas, elas devem possuir o mesmo tamanho e os mesmos elementos nas posições
            if ((matrizA.GetLength(0) == matrizB.GetLength(0)) && (matrizA.GetLength(1) == matrizB.GetLength(1))) // verifica se as dimensões estão corretas
            {
                for (byte linha = 0; linha < matrizA.GetLength(0); linha++) // percorre as matrizes e preenche os elementos
                {
                    for (byte coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                    {
                        matrizA[linha, coluna] = random.Next(0, 3);
                        matrizB[linha, coluna] = random.Next(0, 3);
                        if (matrizA[linha, coluna] != matrizB[linha, coluna]) // caso algum elemento inserido aleatoriamente seja diferente, as matrizes não são iguais.
                        {
                            iguais = false;
                        }
                    } // fim for coluna
                } // fim for linha
            }
            else
            {
                // caso os tamanhos das matrizes sejam diferentes, não são identicas
                iguais = false;
            }            
            if(iguais) Console.WriteLine("As matrizes possuem a mesma quantidade de linhas, colunas e também de elementos!");
            else Console.WriteLine("As matrizes são diferentes.");
        }
    }
}
