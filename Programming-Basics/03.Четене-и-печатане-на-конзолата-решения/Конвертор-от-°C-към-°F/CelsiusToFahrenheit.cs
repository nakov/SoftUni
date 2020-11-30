using System;
class CelsiusToFahrenheit
{
    //5.*Конвертор от °C към °F 
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = a * 1.8 + 32;
        Console.WriteLine(b);
    }
}
