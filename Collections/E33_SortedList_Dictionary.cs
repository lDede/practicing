using System;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class E33
    {
        private Dictionary<string, SortedList<string, decimal>> continentes;
        public E33()
        {
            continentes = new Dictionary<string, SortedList<string, decimal>>();
            SortedList<string, decimal> paisesAfrica = new SortedList<string, decimal>();

            paisesAfrica.Add("Etiópia", 105350016);
            paisesAfrica.Add("Egito", 97041072);
            paisesAfrica.Add("África do Sul", 54841552);
            paisesAfrica.Add("Quênia", 47615740);
            paisesAfrica.Add("Uganda", 39570124);
            paisesAfrica.Add("Argélia", 40969444);

            continentes.Add("África", paisesAfrica);
        }

        public void AdicionarPaises(string chave, SortedList<string, decimal> paises)
        {
            continentes.Add(chave, paises);
        }
        public void RemoverContinente(string chave)
        {
            if (continentes.ContainsKey(chave))
                continentes.Remove(chave);            
            else
                Console.WriteLine("Continente inexistente no dicionário");
        }
        
        public void RemoverPaisDeContinente(string nomeContinente, string nomePais)
        {
            if (continentes.ContainsKey(nomeContinente))
            {
                bool found = false;
                SortedList<string, decimal> paises = continentes[nomeContinente];
                foreach (KeyValuePair<string, decimal> kvp in paises)
                {
                    if(kvp.Key == nomePais)
                    {
                        paises.Remove(nomePais);
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("País inexistente");
            }
            else
                Console.WriteLine("Continente inexistente no dicionário");
        }


        public void ListarPaisesDeContinente(string chave)
        {
            if (continentes.ContainsKey(chave))
            {
                decimal populacaoDosPaises = 0;
                Console.Write("  Continente: {0}\n", chave);
                SortedList<string, decimal> paises = continentes[chave];
                foreach(KeyValuePair<string, decimal> kvp in paises)
                {
                    Console.WriteLine("País: {0} | População: {1}", kvp.Key, kvp.Value);
                    populacaoDosPaises += kvp.Value;
                }
                Console.WriteLine("População total dos países listados: {0}", populacaoDosPaises);
            }
            else
                Console.WriteLine("Continente inexistente no dicionário");
        }

        public void ListarTodos()
        {
            if (continentes != null)
            {
                decimal populacaoDosContinentes = 0;
                foreach (KeyValuePair<string, SortedList<string, decimal>> kvp in continentes)
                {
                    Console.WriteLine();
                    decimal populacaoDosPaises = 0;
                    Console.Write("  Continente: {0}\n", kvp.Key);
                    SortedList<string, decimal> paises = kvp.Value;
                    foreach (KeyValuePair<string, decimal> kvp2 in paises)
                    {
                        Console.WriteLine("País: {0} | População: {1}", kvp2.Key, kvp2.Value);
                        populacaoDosPaises += kvp2.Value;
                    }
                    populacaoDosContinentes += populacaoDosPaises;
                }
                Console.WriteLine("\n\nPopulação total: {0}", populacaoDosContinentes);
            }
            else
                Console.WriteLine("Não há informações sobre os continentes e seus países. Insira um novo e tente novamente.");
        }
    }
}