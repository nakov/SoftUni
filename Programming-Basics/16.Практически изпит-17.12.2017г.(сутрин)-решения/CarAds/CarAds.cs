using System;

class CarAds
{
    //4. Онлайн обяви
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dieselCars = 0;
        int gasolineCars = 0;

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            string carType = Console.ReadLine();
            string fuelType = Console.ReadLine();
            string adStatus = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());

            string category = "";

            if (carType == "coupe" && fuelType == "gasoline")
            {
                if (price > 100000)
                {
                    category = "supersport";
                }
                else
                {
                    category = "sport";
                }
                gasolineCars++;
            }
            else if (carType == "coupe" && fuelType == "diesel")
            {
                category = "ecosport";
                dieselCars++;
            }
            else if (carType == "sedan" && fuelType == "gasoline")
            {
                if (price > 80000)
                {
                    category = "limousine";
                }
                else
                {
                    category = "executive";
                }
                gasolineCars++;
            }
            else if (carType == "sedan" && fuelType == "diesel")
            {
                category = "economic";
                dieselCars++;
            }

            if (adStatus == "vip")
            {
                price += 200;
            }

            Console.WriteLine($"Car model - {model}");
            Console.WriteLine($"Category - {category}");
            Console.WriteLine($"Type - {carType}");
            Console.WriteLine($"Fuel - {fuelType}");
            Console.WriteLine($"Kilometers - {kilometers}");
            Console.WriteLine($"Price - {price:f2}");
        }

        double gasolineCarsPercentage = (gasolineCars * 100.00) / n;
        Console.WriteLine($"Gasoline cars: {gasolineCarsPercentage:f2}%");

        double dieselCarsPercentage = dieselCars * 100.00 / n;
        Console.WriteLine($"Diesel cars: {dieselCarsPercentage:f2}%");
    }
}
