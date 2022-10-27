using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E21
    {
        private SortedList alunos;
        public E21()
        {
            alunos = new SortedList();
        }
        public void CadastrarAluno(int matricula, string nome)
        {
            if (!alunos.ContainsKey(matricula))
            {
                alunos.Add(matricula, nome);
                Console.WriteLine("Aluno cadastrado com sucesso.");
            }
            else
                Console.WriteLine("A matrícula {0} está em uso. Por favor, digite uma nova matrícula para o aluno {1}.", matricula, nome);
        }
        public string PesquisarAluno(int matricula)
        {
            if (alunos.ContainsKey(matricula))
                return "A matrícula " + matricula + " pertence a " + alunos[matricula].ToString();
            else
                return "Aluno inexistente para a matrícula especificada.";
        }
        public bool ExisteAlunos()
        {
            if (alunos.Count > 0)
                return true;
            else
                return false;
        }
    }
}
