using System;

class ConcatenateData
{
    //4.Съединяване на текст и числа
    static void Main()
    {
        var firstname = Console.ReadLine();
        var lastname = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var town = Console.ReadLine();
        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, age, town);
    }
}
