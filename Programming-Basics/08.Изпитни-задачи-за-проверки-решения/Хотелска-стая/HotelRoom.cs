using System;

class HotelRoom
{
    //9.**Хотелска стая
    static void Main()
    {
        string month = Console.ReadLine();
        double nights = double.Parse(Console.ReadLine());

        double studioMO = 50;
        double ApartmentMO = 65;
        double studioJniS = 75.20;
        double ApartmentJniS = 68.70;
        double studioJA = 76;
        double ApartmentJa = 77;
        double priceStudio = 0;
        double priceApartment = 0;

        if (month == "May" || month == "October")
        {
            if (nights <= 7)
            {
                priceStudio = studioMO;
                priceApartment = ApartmentMO;

            }
            else if (nights > 7 && nights <= 14)
            {
                priceStudio = studioMO * 0.95;
                priceApartment = ApartmentMO;

            }
            else if (nights > 14)
            {
                priceStudio = studioMO * 0.70;
                priceApartment = ApartmentMO * 0.9;
            }
        }
        else if (month == "June" || month == "September")
        {
            if (nights >= 15)
            {
                priceStudio = studioJniS * 0.80;
                priceApartment = ApartmentJniS * 0.9;
            }
            else if (nights < 15)
            {
                priceStudio = studioJniS;
                priceApartment = ApartmentJniS;

            }
        }
        else if (month == "July" || month == "August")
        {
            if (nights >= 15)
            {
                priceStudio = studioJA;
                priceApartment = ApartmentJa * 0.90;
            }
            else if (nights < 15)
            {

                priceStudio = studioJA;
                priceApartment = ApartmentJa;
            }
        }

        Console.WriteLine($"Apartment: {(priceApartment * nights):f2} lv.");
        Console.WriteLine($"Studio: {(priceStudio * nights):f2} lv.");
    }
}
