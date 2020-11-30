using System;

class InchesToCentimetres
{
    //2.От инчове към сантиметри
    static void Main()
    {
        Console.Write("inches = ");
        var inches = double.Parse(Console.ReadLine());
        var centimetres = inches * 2.54;
        Console.Write("centimeters = ");
        Console.WriteLine(centimetres);
    }
}
