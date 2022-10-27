using System;

/* PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS - CAMPUS BARREIRO
 * Disciplina: Laboratório de Algoritmos e Estruturas de Dados | 3º Período
 *  Professor: Fábio Leandro Rodrigues Cordeiro
 *      Aluno: André de Sousa Valentim
 *  Matrícula: 640214 
 *  Exercício: Revisão de ATP e POO - Main Page
 */

namespace AEDLab_Aula01
{
    class Program
    {
        private static void Proximo()
        {
            Console.WriteLine("\nPressione qualquer tecla para prosseguir ao próximo exercício.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Exercicio01.Run();
            Proximo();

            Exercicio02.Run();
            Proximo();

            Exercicio03.Run();
            Proximo();

            byte repeat = 0;
            do
            {
                Exercicio04.Run();
                Proximo();
                repeat++;
            } while (repeat < 6);

            Exercicio05.Run();

            Console.WriteLine("Fim da execução. Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
