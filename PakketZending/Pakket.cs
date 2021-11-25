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

        public Pakket(double Lengte, double Breedte, double Hoogte, double Gewicht)
        {
            this.Lengte = Lengte;
            this.Breedte = Breedte;
            this.Hoogte = Hoogte;
            this.Gewicht = Gewicht;
        }
        public double Get_Lengte()
        {
            return this.Lengte;
        }
        public double Get_Hoogte()
        {
            return this.Hoogte;
        }
        public double Get_Breedte()
        {
            return this.Lengte;
        }
        public double Get_Gewicht()
        {
            return this.Gewicht;
        }
    }
}
