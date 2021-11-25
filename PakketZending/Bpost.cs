using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    class Bpost
    {
        private double kostprijsStreek_Kleingewicht = 5.00;
        private double kostprijsStreek_grootgewicht = 15.00;
        private double kostprijsBuitenStreek = 2.00;
        private double gewichtKleinLimit = 10.00;
        private double LimitLengte = 0.5;
        private double LimitHoogte = 0.6;
        private double LimitBreedte = 0.4;
        private List<Pakket> Pakketjes;

        public Bpost()
        {
            Pakketjes = new List<Pakket>();
        }

        //Check of zone 1 en zone2 zelfde begin hebben.
        private bool StreekZelfde(string Zone1, string Zone2)
        {
            if (Zone1.Substring(0, 1).Equals(Zone2.Substring(0, 1)))
            {
                return true;
            }
            return false;
        }

        //Vergelijk Val1 met Val2
        //Val1 = Input klant
        //Val2 = vooropgestelde waardes
        private bool CheckValue(double Val1, double Val2)
        {
            if (Val1 < Val2)
            {
                return true;
            }
            return false;
        }

        //Toevoegen van pakketje als het aan de voorwaarden voldoet.
        public string Voegpakkettoe(Pakket P)
        {
            // Indien alle 3 correct ga verder anders Else
            if (CheckValue(P.Get_Lengte(), LimitLengte) == true &&
                CheckValue(P.Get_Breedte(), LimitBreedte) == true &&
                CheckValue(P.Get_Hoogte(), LimitHoogte) == true)
            {
                Pakketjes.Add(P);
                return "Pakket is succesvol toegevoegd";
            }
            else
            {
                return "Pakket is niet toegevoegd";
            }
        }

        //Oplijsting van pakketjes
        public string ToonPakketjes()
        {
            string Paklijst = "";
            int paknr = 0;
            foreach (var P in Pakketjes)
            {
                paknr++;
                Paklijst += Convert.ToString("Pakje" + paknr + " " + P.Get_Breedte() 
                    + "m breed, " + P.Get_Lengte() + "m lang, " + P.Get_Hoogte() 
                    + "m hoog, " + P.Get_Gewicht() + "Kg zwaar\n");
            }

            return Paklijst;
        }

        /// <summary>
        /// Indien zelfde streek en gewicht < 10Kg -> 5€ 
        /// Indien zelfde streek en gewicht >=10KG -> 15€ 
        /// Indien andere streek en gewicht < 10Kg -> 7€ 
        /// Indien andere streek en gewicht >=10 Kg -> 17€ 
        /// Prijs onder 10 kilogram = € 5 prijs boven 10 kilogram is € 15
        /// Niet zelfde streek is prijs plus 2 euro

        public string Kostprijsberekening(string beginZone, string eindZone)
        {
            double kostprijs = 0D, gewichtPakket = 0D;
            string resultaat = "";
            foreach (var P in Pakketjes)
            {
                gewichtPakket = P.Get_Gewicht();
                //Gewicht check 
                if (gewichtPakket < gewichtKleinLimit)
                {
                    kostprijs += kostprijsStreek_Kleingewicht;
                }
                else
                {
                    kostprijs += kostprijsStreek_grootgewicht;
                }

                if (StreekZelfde(beginZone, eindZone) == false)
                {
                    kostprijs += kostprijsBuitenStreek;
                }
            }
            resultaat = "Kostprijs is " + Convert.ToString(kostprijs) + "€." + "\n";
            return resultaat;
        }
    }
}

