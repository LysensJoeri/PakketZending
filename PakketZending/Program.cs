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
            string keuze;
            double Inv_Lengte,Inv_Breedte,Inv_Hoogte,Inv_Gewicht;
            Console.WriteLine("Welkom bij de post, indien je wilt stoppen type exit.");
            keuze = "";

            while (keuze != "exit" )
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
                Zending zend = new Zending();
                //if (zend.Control_Pakket(p))
                if (zend.Control_Pakket() == true)
                {

                }
                

                Console.Write("Exit?: ");
                keuze = Console.ReadLine();
            }
            
            

        }
    }
}
