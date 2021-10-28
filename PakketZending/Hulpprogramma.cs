using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakketZending
{
    public class Hulpprogramma
    {

        //Returns Double value na replace . -> , en convert to string
        public static double CheckInputDouble(string input)
        {
            double result = 0d;
            try
            {
                input = input.Replace("m", "");
                input = input.Replace(".", ",");
                result = Convert.ToDouble(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Geen gelding input!!!!");
                Console.Write("Geef nieuw waarde in: ");
                result = CheckInputDouble(Console.ReadLine());

            }
            return result;
        }
    }
}
