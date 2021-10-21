using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Zending
    {
        private bool streek = false;
        private double gewicht = 0.0;
        private double kostprijs = 0.0;
        private double MeerprijsStreek = 0.0;

        

        public Zending()
        {
            //Controleer data
        }

        /// <summary>
        /// Indien zelfde streek en gewicht < 10Kg -> 5€ 
        /// Indien zelfde streek en gewicht >=10KG -> 15€ 
        /// Indien andere streek en gewicht < 10Kg -> 7€ 
        /// Indien andere streek en gewicht >=10 Kg -> 17€ 
        /// Prijs onder 10 kilogram = € 5 prijs boven 10 kilogram is € 15
        /// Niet zelfde streek is prijs plus 2 euro
        public double kostprijsberekening(double gewicht, bool streek)
        {
            if (gewicht < 10)
            {
                kostprijs = 5.00;
            }
            else 
            {
                kostprijs = 15.00;
            } 
            
            if(streek == false)
            {
                kostprijs += 2.00;
            }
            return gewicht;            
        }

        private bool Control_Pakket(Pakket p)
        {
            p.Get_Lengte();
            p.Get_Breedte();
            p.Get_Hoogte();
            p.Get_Gewicht();
            
            return true;
        }

        public bool zoneControlle(string beginZone, string eindZone)
        {
            return true;
        }

        
        
    }
}
