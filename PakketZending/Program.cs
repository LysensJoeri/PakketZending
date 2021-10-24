using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ZelfdeStreek;
            string keuze, Zone1, Zone2;
            double Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht;
            Console.WriteLine("Welkom bij de post, indien je wilt stoppen type exit.");
            keuze = "";

            while (keuze != "exit" && keuze != "y")
            {                
                Console.WriteLine("Gelieve de volgende gegevens van het paketje even in te geven");
                Console.Write("Lengte: ");
                Inv_Lengte = Convert.ToDouble(Console.ReadLine().Replace(".",","));
                Console.Write("Breedte: ");
                Inv_Breedte = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.Write("Hoogte: ");
                Inv_Hoogte = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.Write("Gewicht: ");
                Inv_Gewicht = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

                Pakket p = new Pakket(Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht);
                //Zending zend = new Zending();

                Console.Write("Zend Postocde: ");
                Zone1 = Console.ReadLine();
                Console.Write("Bestemming Postcode: ");
                Zone2 = Console.ReadLine();
                //ZelfdeStreek = zend.(Zone1, Zone2);
                //Console.WriteLine(zend.kostprijsberekening(p, Zone1, Zone2));
                Zending zend = new Zending();
                double gewicht = Inv_Gewicht;
                string beginZone = Zone1;
                string eindZone = Zone2;
                zend.kostprijsberekening(gewicht, beginZone, eindZone);

                Console.Write("Exit?: ");
                keuze = Console.ReadLine();
            }
            
            

        }
    }
}
