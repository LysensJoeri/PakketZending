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
            //bool ZelfdeStreek;
            string keuze, Zone1, Zone2;
            double Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht;
            Console.WriteLine("Welkom bij de post, indien je wilt stoppen type exit.");
            keuze = "";

            while (!keuze.ToLower().Equals("exit") && !keuze.ToLower().Equals("y"))
            {                
                Console.WriteLine("Gelieve de volgende gegevens van het paketje even in te geven");
                Console.Write("Lengte: ");
                Inv_Lengte = CheckInputDouble(Console.ReadLine());
                Console.Write("Breedte: ");
                Inv_Breedte = CheckInputDouble(Console.ReadLine());
                Console.Write("Hoogte: ");
                Inv_Hoogte = CheckInputDouble(Console.ReadLine());
                Console.Write("Gewicht: ");
                Inv_Gewicht = CheckInputDouble(Console.ReadLine());

                Pakket p = new Pakket(Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht);
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

        public static double CheckInputDouble(string input)
        {
            double result=0d;
            try
            {
                input = input.Replace(".", ",");
                result = Convert.ToDouble(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Geen gelding input!!!!");
                Console.Write("Geef nieuw waarde in: ");
                result = CheckInputDouble(Console.ReadLine());

            }
            return result;
        }
    }
}
