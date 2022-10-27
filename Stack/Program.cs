using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_Exercicio01_FilaPilha
{
    class Program
    {
        static Queue CriaQueue(int quantidade)
        {
            Queue Q = new Queue();
            for (int i = 1; i <= quantidade; i++)
                Q.Enqueue(i);
            return Q;
        }

        static Stack CriaStack(int quantidade)
        {
            Stack S = new Stack();
            for (int i = 1; i <= quantidade; i++)
                S.Push(i);
            return S;
        }
        static void ImprimeQueue(Queue Q)
        {
            foreach (int n in Q)
                Console.Write(Q.Dequeue() + " ");
        }

        static void ImprimeStack(Stack S)
        {
            foreach (int n in S)
                Console.Write(S.Pop() + " ");
        }
        static void Main(string[] args)
        {
            // Exercício 1;
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            foreach (int n in fila)
                Console.Write(fila.Dequeue() + " ");


            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            foreach (int n in pilha)
                Console.Write(pilha.Pop() + " ");
            

            fila = CriaQueue(5);
            ImprimeQueue(fila);

            pilha = CriaStack(5);
            ImprimeStack(pilha);
            
        }
    }
}
