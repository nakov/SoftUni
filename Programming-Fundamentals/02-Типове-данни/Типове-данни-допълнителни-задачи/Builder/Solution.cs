using System;

namespace Builder
{
    /*
    Вие сте строител и трябва да купите материали за един от вашите клиенти. 
    Това е специална къща и ще има нужда от специални материали. 
    Тази къща има нужда от 4 sbyte променливи и 10 int променливи. 
    Ще получите две числа от конзолата, които ще бъдат цената на материалите. 
    Първото ще бъде цяло число, а другото ще бъде sbyte, но няма да знаете в какъв ред ще бъдат дадени. 
    Числото в int ще бъде цената на int материалите, а числото в sbyte ще е цената на sbyte материалите. 
    Изчислете общата цена на материалите и ги изведете на конзолата.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(price1, price2) * 10 + Math.Min(price1, price2) * 4);
        }
    }
}
