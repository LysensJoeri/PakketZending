using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    class Program
    {
        public static void Main(string[] args)
        {
            string keuze, Zone1, Zone2;
            double Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht;
            Console.WriteLine("Welkom bij de post, indien je wilt stoppen type exit.");
            keuze = "test";

            //Loop tot Exit of Y (alle vormen toegestaan)
            while (!keuze.ToLower().Equals("exit") && !keuze.ToLower().Equals("y"))
            {
                Console.WriteLine("Gelieve de volgende gegevens van het paketje even in te geven");
                Console.WriteLine("Geldige Afmetingen :");
                Console.WriteLine("Lengte korter dan 0,5m / Breedte smaller dan 0,4m / Hoogte kleiner dan 0,6m ");
                Console.Write("Lengte: ");
                Inv_Lengte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                Console.Write("Breedte: ");
                Inv_Breedte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                Console.Write("Hoogte: ");
                Inv_Hoogte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                Console.Write("Gewicht: ");
                Inv_Gewicht = Hulpprogramma.CheckInputDouble(Console.ReadLine());

                Pakket p = new Pakket(Inv_Lengte, Inv_Breedte, Inv_Hoogte, Inv_Gewicht);
                Zending zend = new Zending();

                Console.Write("Zend Postocde: ");
                Zone1 = Console.ReadLine();
                Console.Write("Bestemming Postcode: ");
                Zone2 = Console.ReadLine();

                Console.WriteLine(zend.kostprijsberekening(p, Zone1, Zone2));


                Console.Write("Exit?: ");
                keuze = Console.ReadLine();
            }
        }
    }
}
