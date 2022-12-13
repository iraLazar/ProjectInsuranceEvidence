using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Evidence
    {
        List<Pojistenec> pojistenci = new List<Pojistenec>();

         public void VyhledejPojistence()
        {

            Console.WriteLine("Zadej jméno: ");
            string vyhledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadej přijmení: ");
            string vyhledanePrijmeni = Console.ReadLine();
            var dotaz = from p in pojistenci
                        where (p.Jmeno.Contains(vyhledaneJmeno) &&
                               p.Prijmeni.Contains(vyhledanePrijmeni))
                        select p;
            foreach (Pojistenec p in dotaz)
                Console.WriteLine(p);

        }
        public void VytvoreniPojistence()
        {

            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmenoPojistence = Console.ReadLine();
            Console.WriteLine("Zadejte přijmení:");
            string prijmeniPojistence = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo:");
            ulong telefonniCisloPojistence = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk:");
            int vekPojistence = int.Parse(Console.ReadLine());

            pojistenci.Add(new Pojistenec(jmenoPojistence, prijmeniPojistence, vekPojistence, telefonniCisloPojistence));

            Console.WriteLine("Data byla uložená. Pokračujte libovolnou klávesou...");

            
        }

        public void VypisPojistence()
        {
            foreach(Pojistenec p in pojistenci)
                Console.WriteLine(p);

        }


    }
}
