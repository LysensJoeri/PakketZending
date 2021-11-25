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
            Zending zend = new Zending();
            double Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht;
            Menu();
            keuze = Console.ReadLine();

            //Loop tot 0 getypt word
            while (keuze != "0")
            {
                switch (keuze)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Gelieve de volgende gegevens van het paketje even in te geven");
                        Console.Write("Lengte: ");
                        Inv_Lengte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                        Console.Write("Breedte: ");
                        Inv_Breedte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                        Console.Write("Hoogte: ");
                        Inv_Hoogte = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                        Console.Write("Gewicht: ");
                        Inv_Gewicht = Hulpprogramma.CheckInputDouble(Console.ReadLine());
                        Pakket Pak = new Pakket(Inv_Lengte, Inv_Breedte, Inv_Hoogte, Inv_Gewicht);
                        Console.WriteLine(zend.Voegpakkettoe(Pak));                       
                        break;

                    case "2":                        
                        Console.Write("Verstuur van: ");
                        Zone1 = Console.ReadLine();
                        Console.Write("Verstuur naar: ");
                        Zone2 = Console.ReadLine();        
                        Console.WriteLine(zend.Kostprijsberekening(Zone1, Zone2));
                       /* Console.Write("Verzending voltooien? (y/n) :");
                        keuze = Console.ReadLine();
                        if(keuze.ToLower() == "y")
                        {
                            zend.Leegmakenlijst();
                        }*/
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine(zend.ToonPakketjes());
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Gelieve een correcte keuze te maken.");
                        break;
                }
                Console.WriteLine();
                Menu();
                keuze = Console.ReadLine();
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Welkom bij de post, indien je wilt stoppen type exit.");
            Console.WriteLine("1. maak een pakketje aan");
            Console.WriteLine("2. Bereken prijd verzending");
            Console.WriteLine("3. Toon pakketjes");
            Console.WriteLine("0. Stoppen");
            Console.Write("Keuze : ");
        }
    }
}
