
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------\nEvidence pojištěných\n------------------------");

            Evidence evidence = new Evidence();
            int prikaz=0;
            bool konec = false;
            do
            {
                
                VypisMenu();
                Console.Write("Zadej příkaz: ");
                prikaz = int.Parse(Console.ReadLine());
                switch (prikaz)
                {
                    case 1:
                        evidence.VytvoreniPojistence();
                        break;
                    case 2:
                        evidence.VypisPojistence();
                        break;
                    case 3:
                        evidence.VyhledejPojistence();
                        break;
                    case 4:
                        konec = true;
                        Console.WriteLine("Pro skončení zmáčkněte libovolnou klávesu");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
            while (!konec);
            




            Console.ReadKey();
        }



        static void VypisMenu()
        {
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěne");
            Console.WriteLine("3 - Vyhledat pojíštěného");
            Console.WriteLine("4 - Konec");
        }

        

    }
}

