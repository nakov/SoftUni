﻿using System;

namespace FloatingPointNumbers
{
    class Solution
    {
        /* 7. Числа с плаваща запетая
        Напишете програма, която присвоява числа с плаваща запетая на променливи. 
        Уверете се, че всяка  стойност се запазва в коректен тип 
        (изберете най-удобния тип спрямо количеството памета, което той заема). 
        Накрая трябва да изведете всички променливи.
        */
        static void Main(string[] args)
        {
            decimal a = 3.141592653589793238m;
            double b = 1.60217657d;
            decimal c = 7.8184261974584555216535342341m;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
