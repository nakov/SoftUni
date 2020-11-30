using System;

namespace SpeedConversion
{
    class Solution
    {
        /* 11.	Преобразуване на скорост
        Напишете програма, която въвежда разстояние (в метри) и време (като три числа: часове, минути, секунди), и изведете скоростта, в метри за секунда, километри в час и мили в час.
        Приемете, че 1 миля = 1609 метра.
        */
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float hourTime = hours + minutes / 60.0f + seconds / 3600.0f;

            float kmSpeed = (distance / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distance / 1609.0f) / hourTime;

            Console.WriteLine(metersSpeed);
            Console.WriteLine(kmSpeed);
            Console.WriteLine(milesSpeed);
        }
    }
}
