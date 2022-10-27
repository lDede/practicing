using System;
using System.Collections.Generic;

namespace AEDLab_AtividadeAvaliativa
{
    class Program
    {
        static void Main(string[] args)
        {
            E33 e33 = new E33();
            SortedList<string, decimal> paisesAmerica = new SortedList<string, decimal>();
            paisesAmerica.Add("Estados Unidos", 326625792);
            paisesAmerica.Add("Brasil", 207353392);
            paisesAmerica.Add("México", 124574792);
            paisesAmerica.Add("Argentina", 44293292);
            paisesAmerica.Add("Canadá", 35623680);
            paisesAmerica.Add("Peru", 31036656);
            e33.AdicionarPaises("América", paisesAmerica);

            SortedList<string, decimal> paisesAsia = new SortedList<string, decimal>();
            paisesAsia.Add("China", 1379302784);
            paisesAsia.Add("Índia", 1281935872);
            paisesAsia.Add("Paquistão", 204924864);
            paisesAsia.Add("Bangladesh", 157826576);
            paisesAsia.Add("Japão", 126451400);
            paisesAsia.Add("Vietnã", 96160160);
            e33.AdicionarPaises("Europa", paisesAsia);

            SortedList<string, decimal> paisesEuropa = new SortedList<string, decimal>();
            paisesEuropa.Add("Alemanha", 80594016);
            paisesEuropa.Add("França", 67106160);
            paisesEuropa.Add("Reino Unido", 64769452);
            paisesEuropa.Add("Itália", 62137800);
            paisesEuropa.Add("Espanha", 48958160);
            paisesEuropa.Add("Países Baixos", 17084720);
            e33.AdicionarPaises("Ásia", paisesEuropa);

            e33.ListarPaisesDeContinente("África");
            e33.RemoverContinente("África");
            Console.WriteLine();
            Console.WriteLine();
            e33.RemoverPaisDeContinente("Ásia", "China");
            e33.ListarTodos();
        }
    }
}
