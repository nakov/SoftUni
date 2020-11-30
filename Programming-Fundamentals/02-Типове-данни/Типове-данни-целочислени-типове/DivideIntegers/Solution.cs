using System;

namespace DivideIntegers
{
    class solution
    {
        /* 6. Делене на цели числа
        Напишете програма, която въвежда едно цяло число n. 
        След това програмата въвежда 2n на брой цели числа, всяко на отделен ред. 
        Програмата да извежда целочислената загуба от деленията на всяка двойка числа. 
        Целочислена загуба дефинираме като сумата от остатъците от деленето на: 
        първото на второто число, третото на четвъртото число и т.н.
        */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, b, sum = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                sum += a % b;
            }
            Console.WriteLine(sum);
        }
    }
}
