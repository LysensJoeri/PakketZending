using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Zending
    {
        private double kostprijs;
        private string resultaat = "";

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
            if (gewicht < 10)
            {
                kostprijs = 5.00;
            }
            else
            {
                kostprijs = 15.00;
            }

            if (beginZone.Substring(0, 1) != (eindZone.Substring(0, 1)))
            {
                kostprijs += 2.00;
            }
            resultaat = Convert.ToString(kostprijs);
            return resultaat;
        }
    }
}
