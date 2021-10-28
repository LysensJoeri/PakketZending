using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Zending
    {
        private double kostprijsStreek_Kleingewicht = 5.00;
        private double kostprijsStreek_grootgewicht = 15.00;
        private double kostprijsBuitenStreek = 2.00;
        private double gewichtKleinLimit = 10.00;
        private string resultaat = "";
        private double kostprijs = 0D;
        private double gewichtPakket = 0D;
        private double LimitLengte = 0.5;
        private double LimitHoogte = 0.6;
        private double LimitBreedte = 0.4;
        //public string beginZone = "";
        //public string eindZone = "";
        //public double gewicht = 0.00;

        private bool StreekZelfde(string Zone1, string Zone2)
        {
            if(Zone1.Substring(0, 1).Equals(Zone2.Substring(0, 1)))
            {
                return true;
            }
            return false;
        }
        
        private bool CheckValue(double Val1, double Val2)
        {
            if(Val1 < Val2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Indien zelfde streek en gewicht < 10Kg -> 5€ 
        /// Indien zelfde streek en gewicht >=10KG -> 15€ 
        /// Indien andere streek en gewicht < 10Kg -> 7€ 
        /// Indien andere streek en gewicht >=10 Kg -> 17€ 
        /// Prijs onder 10 kilogram = € 5 prijs boven 10 kilogram is € 15
        /// Niet zelfde streek is prijs plus 2 euro
        public string kostprijsberekening(Pakket p, string beginZone, string eindZone)
        {
            if (CheckValue(p.Get_Lengte(), LimitLengte) == true &&
                CheckValue(p.Get_Breedte(), LimitBreedte) == true &&
                CheckValue(p.Get_Hoogte(), LimitHoogte) == true)
            {

                gewichtPakket = p.Get_Gewicht();


                if (gewichtPakket< gewichtKleinLimit)
                {
                    kostprijs = kostprijsStreek_Kleingewicht;
                }
                else
                {
                    kostprijs = kostprijsStreek_grootgewicht;
                }

                if (StreekZelfde(beginZone,eindZone) == false)
                {
                    kostprijs += kostprijsBuitenStreek;
                }
                resultaat = "De kostprijs voor het versturen van dit pakket is: " + Convert.ToString(kostprijs);
            }
            else
            {
                resultaat = "Waardes van het pakje zijn incorrect!!";
            }
            return resultaat;
        }
    }
}
