﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    class Pakket
    {
        private double Lengte, Hoogte, Breedte, Gewicht;

        public Pakket(double Inv_Lengte, double Inv_Breedte, double Inv_Hoogte, double Inv_Gewicht)
        {
            Lengte = Inv_Lengte;
            Breedte = Inv_Breedte;
            Hoogte = Inv_Hoogte;
            Gewicht = Inv_Gewicht;
        }
    }
}