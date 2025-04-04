using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryANPRVerbetering;

namespace TestANPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inlezen van het bestand
            BestandIO bestandio = new BestandIO();
            List<string> registraties = new List<string>();
            registraties = bestandio.Ophalen(@"c:\data\registraties.txt");

            //zoeken naar overeenkomsten
            Console.Write("Welke (gedeeltelijke) nummerplaat wil je zoeken? ");
            string zoeken = Console.ReadLine();
            ANPR anpr = new ANPR(zoeken, registraties);
            List<string> resultaten = new List<string>();
            resultaten = anpr.Zoeken();

            //uitvoer + wegschrijven
            Console.WriteLine();
            if (resultaten.Count == 0)
            {
                Console.WriteLine("Er werden geen overeenkomsten gevonden.");
            }
            else
            {
                foreach (string item in resultaten)
                {
                    Console.WriteLine(item);
                }
                bestandio.Wegschrijven(@"c:\data\resultaten",resultaten);
            }
            
            Console.ReadKey();
        }
    }
}
