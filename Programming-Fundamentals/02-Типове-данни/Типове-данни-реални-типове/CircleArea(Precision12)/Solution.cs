using System;

namespace CircleArea_Precision12_
{
    class Solution
    {
        /* 8. Лице на кръг (с точност 12 знака)
        Напишете програма, в която въвеждаме радиус r (реално число) и извеждаме лицето на кръг с точно 12 знака след десетичната запетая. 
        Използвайте тип данни с подходяща точност за съхранение на резултатите.
        */
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine("{0:f12}", area);
        }
    }
}
