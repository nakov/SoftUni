using System;

namespace ComparingFloats
{
    /*
     Напишете програма, която да сравнява числа с плаваща запетая сигурно, като точността трябва да е eps = 0.000001. 
    Забележете, че не можем директно да сравним две числа с плаваща запетая a и b чрез a==b 
    заради природата на аритметиката на числата с плаваща запетая. 
    Затова приемаме, че две числа са еднакви, ако те са по-близо едно до друго от зададен eps. 
    Ще получите два реда, всеки от тях съдържа число с плаваща запетая. 
    Вашата задача е да сравните стойностите на двете числа.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            double firstNumber = (double.Parse(Console.ReadLine()));
            double secondNumber = (double.Parse(Console.ReadLine()));
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;
            Console.WriteLine(equal);
        }
    }
}
