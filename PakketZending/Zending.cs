using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Zending
    {
        private double kostprijsStreek_kleinerdanTien = 5.00;
        private double kostprijsStreek_groterdanTien = 15.00;
        private double kostprijsBuitenStreek = 2.00;
        private double gewichtKleinderdan = 10.00;
        private string resultaat = "";
        //public string beginZone = "";
        //public string eindZone = "";
        //public double gewicht = 0.00;

        public Zending()
        {

        }

        /// <summary>
        /// Indien zelfde streek en gewicht < 10Kg -> 5€ 
        /// Indien zelfde streek en gewicht >=10KG -> 15€ 
        /// Indien andere streek en gewicht < 10Kg -> 7€ 
        /// Indien andere streek en gewicht >=10 Kg -> 17€ 
        /// Prijs onder 10 kilogram = € 5 prijs boven 10 kilogram is € 15
        /// Niet zelfde streek is prijs plus 2 euro
        public string kostprijsberekening(double gewicht, string beginZone, string eindZone)
        {

            double kostprijs;
            if (gewicht < gewichtKleinderdan)
            {
                kostprijs = kostprijsStreek_kleinerdanTien;
            }
            else
            {
                kostprijs = kostprijsStreek_groterdanTien;
            }

            if (beginZone.Substring(0, 1) != (eindZone.Substring(0, 1)))
            {
                kostprijs += kostprijsBuitenStreek;
            }
            resultaat = Convert.ToString(kostprijs);
            return resultaat;
        }
    }
}
