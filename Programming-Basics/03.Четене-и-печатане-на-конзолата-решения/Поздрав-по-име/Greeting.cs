using System;

class Greeting
{
    //3.Поздрав по име
    static void Main()
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
