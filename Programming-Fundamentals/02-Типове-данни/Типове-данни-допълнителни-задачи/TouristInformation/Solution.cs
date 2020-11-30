using System;

namespace TouristInformation
{
    /*
    Напишете програма, която помага на туристите да преобразуват империални мерки към метричната система. 
    Вашата програма трябва да поддържа следните преобразувания: 
    мили към километри, инчове към сантиметри, футове към сантиметри, ярдове към метри и галони към литри. 
    */
    class Solution
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine();
            decimal impUnitsValue = decimal.Parse(Console.ReadLine());
            decimal metricValue = 0;
            string metricUnits = "";

            switch (imperialUnits)
            {
                case "miles":
                    metricUnits = "kilometers";
                    metricValue = impUnitsValue * 1.6m;
                    break;
                case "inches":
                    metricUnits = "centimeters";
                    metricValue = impUnitsValue * 2.54m;
                    break;
                case "feet":
                    metricUnits = "centimeters";
                    metricValue = impUnitsValue * 30m;
                    break;
                case "yards":
                    metricUnits = "meters";
                    metricValue = impUnitsValue * 0.91m;
                    break;
                case "gallons":
                    metricUnits = "liters";
                    metricValue = impUnitsValue * 3.8m;
                    break;
            }

            Console.WriteLine("{0} {1} = {2:F2} {3}", impUnitsValue, imperialUnits, metricValue, metricUnits);
        }
    }
}
