using System;

class SleepingCatTom
{
    //3.*Поспаливата котка Том 
    private const int OneYearDays = 365;
    private const int NeededGameMinutes = 30000;
    private const int MinutesForGameInWorkingDay = 63;
    private const int MinutesForGameInDayOff = 127;

    static void Main()
    {
        int DaysOff = int.Parse(Console.ReadLine());
        int workingDays = OneYearDays - DaysOff;
        int realGameMinutes = workingDays * MinutesForGameInWorkingDay + DaysOff * MinutesForGameInDayOff;

        if (NeededGameMinutes >= realGameMinutes)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{(NeededGameMinutes - realGameMinutes) / 60} hours and {(NeededGameMinutes - realGameMinutes) % 60} minutes less for play");
        }
        else
        {
            Console.WriteLine($"Tom will run away");
            Console.WriteLine($"{(realGameMinutes - NeededGameMinutes) / 60} hours and {(realGameMinutes - NeededGameMinutes) % 60} minutes more for play");
        }
    }
}
