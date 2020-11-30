using System;
class _1000DaysAfterBirth
{
    //6.**1000 дни на Земята
    static void Main()
    {
        string myDate = Console.ReadLine();
        string format = "dd-MM-yyyy";

        var parsedDate = DateTime.ParseExact(myDate, format, null);
        parsedDate = parsedDate.AddDays(1000 - 1);

        Console.WriteLine(parsedDate.ToString(format));
    }
}

