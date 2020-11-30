using System;

class TrainingLab
{
    //7.*Учебна зала
    static void Main()
    {
        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double row = Math.Truncate(lenght / 1.2);
        double colomn = Math.Truncate((width - 1) / 0.7);

        double places = (row * colomn) - 3;
        Console.WriteLine(places);
    }
}

