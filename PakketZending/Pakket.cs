using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Pakket
    {
        private double Lengte=0D, Hoogte = 0D, Breedte = 0D, Gewicht = 0D;

        public Pakket(double Inv_Lengte, double Inv_Breedte, double Inv_Hoogte, double Inv_Gewicht)
        {
            Lengte = Inv_Lengte;
            Breedte = Inv_Breedte;
            Hoogte = Inv_Hoogte;
            Gewicht = Inv_Gewicht;
        }
        public double Get_Lengte()
        {
            return Lengte;
        }
        public double Get_Hoogte()
        {
            return Hoogte;
        }
        public double Get_Breedte()
        {
            return Lengte;
        }
        public double Get_Gewicht()
        {
            return Gewicht;
        }
    }
}
