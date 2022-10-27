﻿using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E22
    {
        private Hashtable montadoras;
        private ArrayList carrosFiat;
        private ArrayList carrosVolkswagen;
        private ArrayList carrosFord;
        private ArrayList carrosGM;
        public E22()
        {
            montadoras = new Hashtable();
            carrosFiat = new ArrayList();
            carrosVolkswagen = new ArrayList();
            carrosFord = new ArrayList();
            carrosGM = new ArrayList();

            PreencherArrayListCarrosFiat();
            PreencherArrayListCarrosFord();
            PreencherArrayListCarrosGM();
            PreencherArrayListCarrosVolkswagen();
            PreencherEmDicionario();

        }
        private void PreencherArrayListCarrosFiat()
        {
            carrosFiat.Add("Mille");
            carrosFiat.Add("Novo Uno");
            carrosFiat.Add("Palio");
            carrosFiat.Add("Siena");
            carrosFiat.Add("Freemont");
            carrosFiat.Add("Bravo");
            carrosFiat.Add("Punto");
            carrosFiat.Add("Linea");
            carrosFiat.Add("Palio Weekend");
        }
        private void PreencherArrayListCarrosVolkswagen()
        {
            carrosVolkswagen.Add("Gol");
            carrosVolkswagen.Add("Voyage");
            carrosVolkswagen.Add("Polo");
            carrosVolkswagen.Add("Passat");
            carrosVolkswagen.Add("Amarok");
            carrosVolkswagen.Add("Fox");
            carrosVolkswagen.Add("Golf");
            carrosVolkswagen.Add("Jetta");
            carrosVolkswagen.Add("Tiguan");
        }
        private void PreencherArrayListCarrosFord()
        {
            carrosFord.Add("Focus");
            carrosFord.Add("Fiesta");
            carrosFord.Add("Ka");
            carrosFord.Add("New Fiesta");
            carrosFord.Add("Fusion");
            carrosFord.Add("Edge");
        }
        private void PreencherArrayListCarrosGM()
        {
            carrosGM.Add("Celta");
            carrosGM.Add("Classic");
            carrosGM.Add("Prisma");
            carrosGM.Add("Agile");
            carrosGM.Add("Omega");
            carrosGM.Add("Cruze");
            carrosGM.Add("Camaro");
            carrosGM.Add("Malibu");
        }

        private void PreencherEmDicionario()
        {
            montadoras.Add("Fiat", carrosFiat);
            montadoras.Add("Volkswagen", carrosVolkswagen);
            montadoras.Add("Ford", carrosFord);
            montadoras.Add("GM", carrosGM);
        }

        public void ProcurarMontadora(string montadoraParam)
        {
            if (montadoras.ContainsKey(montadoraParam))
            {
                Console.Write("  Montadora: " + montadoraParam);
                Console.Write("\n     Carros: ");

                ArrayList A = (ArrayList)montadoras[montadoraParam];
                foreach(string carro in A)
                    Console.Write(carro + " | ");

                Console.WriteLine("\nQtde Carros: {0}", A.Count);
            }
            else
                Console.WriteLine("Montadora inexistente no dicionário");
        }
    }
}
