using System;

class DailyEarnings
{
    //11.*Дневна печалба
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double moneyPerDay = double.Parse(Console.ReadLine());
        double moneyCourse = double.Parse(Console.ReadLine());

        double salary = days * moneyPerDay;
        double yearIncome = (salary * 12) + (salary * 2.5);
        double taxes = yearIncome * 25 / 100;
        double pureYearIncomeInLv = (yearIncome - taxes) * moneyCourse;
        double dailyEarnings = pureYearIncomeInLv / 365;

        Console.WriteLine($"{dailyEarnings:f2}");
    }
}
