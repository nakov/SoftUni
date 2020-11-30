using System;

class SquareArea
{
    //1.Пресмятане на лице на квадрат
    static void Main()
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square = ");
        Console.WriteLine(area);
    }
}
