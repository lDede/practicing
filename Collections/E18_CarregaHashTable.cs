using System;
using System.Collections;

namespace AEDLab_AtividadeAvaliativa
{
    class E18
    {
        private Hashtable nucleotideos = new Hashtable();
        private Random rd = new Random();
        public E18()
        {
            CarregarHashTable();
        }
        private void CarregarHashTable()
        {
            nucleotideos.Add("UUU", "Fenilatanina");
            nucleotideos.Add("UUC", "Fenilatanina");

            nucleotideos.Add("UUA", "Leucina");
            nucleotideos.Add("UUG", "Leucina");
            nucleotideos.Add("CUU", "Leucina");
            nucleotideos.Add("CUC", "Leucina");
            nucleotideos.Add("CUA", "Leucina");
            nucleotideos.Add("CUG", "Leucina");


            nucleotideos.Add("AUU", "Isoleucina");
            nucleotideos.Add("AUC", "Isoleucina");
            nucleotideos.Add("AUA", "Isoleucina");


            nucleotideos.Add("AUG", "Metlonina");


            nucleotideos.Add("GUU", "Valina");
            nucleotideos.Add("GUC", "Valina");
            nucleotideos.Add("GUA", "Valina");
            nucleotideos.Add("GUG", "Valina");


            nucleotideos.Add("UCU", "Serina");
            nucleotideos.Add("UCC", "Serina");
            nucleotideos.Add("UCA", "Serina");
            nucleotideos.Add("UCG", "Serina");
            nucleotideos.Add("AGU", "Serina");
            nucleotideos.Add("AGC", "Serina");


            nucleotideos.Add("CCU", "Prolina");
            nucleotideos.Add("CCC", "Prolina");
            nucleotideos.Add("CCA", "Prolina");
            nucleotideos.Add("CCG", "Prolina");

            nucleotideos.Add("ACU", "Treonina");
            nucleotideos.Add("ACC", "Treonina");
            nucleotideos.Add("ACA", "Treonina");
            nucleotideos.Add("ACG", "Treonina");

            nucleotideos.Add("GCU", "Alanina");
            nucleotideos.Add("GCC", "Alanina");
            nucleotideos.Add("GCA", "Alanina");
            nucleotideos.Add("GCG", "Alanina");


            nucleotideos.Add("UAU", "Tirosina");
            nucleotideos.Add("UAC", "Tirosina");

            nucleotideos.Add("UAA", "Parada");
            nucleotideos.Add("UAG", "Parada");
            nucleotideos.Add("UGA", "Parada");

            nucleotideos.Add("CAU", "Histidina");
            nucleotideos.Add("CAC", "Histidina");

            nucleotideos.Add("CAA", "Glutamina");
            nucleotideos.Add("CAG", "Glutamina");


            nucleotideos.Add("AAU", "Asparagina");
            nucleotideos.Add("AAC", "Asparagina");


            nucleotideos.Add("AAA", "Lisina");
            nucleotideos.Add("AAG", "Lisina");

            nucleotideos.Add("GAU", "Aspartato");
            nucleotideos.Add("GAC", "Aspartato");


            nucleotideos.Add("GAA", "Glutamato");
            nucleotideos.Add("GAG", "Glutamato");

            nucleotideos.Add("UGU", "Cisteina");
            nucleotideos.Add("UGC", "Cisteina");

            nucleotideos.Add("UGG", "Triptofano");

            nucleotideos.Add("CGU", "Arginina");
            nucleotideos.Add("CGC", "Arginina");
            nucleotideos.Add("CGA", "Arginina");
            nucleotideos.Add("CGG", "Arginina");
            nucleotideos.Add("AGA", "Arginina");
            nucleotideos.Add("AGG", "Arginina");

            nucleotideos.Add("GGU", "Glicina");
            nucleotideos.Add("GGC", "Glicina");
            nucleotideos.Add("GGA", "Glicina");
            nucleotideos.Add("GGG", "Glicina");
        }


        public void VerificarCodigoGenetico(string trinca)
        {
            if (nucleotideos.ContainsKey(trinca))
                Console.Write(this.nucleotideos[trinca].ToString());
            else
                Console.Write("Não existe nucleotídeo correspondente a trinca digitada");

            Console.WriteLine();
        }

        public string GerarTrinca()
        {
            string concat = "";
            int repeat = 3;
            while (repeat > 0)
            {
                int numero = rd.Next(1, 5);
                switch (numero)
                {
                    case 1: concat += "U";
                        break;
                    case 2: concat += "C";
                        break;
                    case 3: concat += "A";
                        break;
                    case 4: concat += "G";
                        break;
                }
                repeat--;
            }
            return concat;
        }
    }
}
