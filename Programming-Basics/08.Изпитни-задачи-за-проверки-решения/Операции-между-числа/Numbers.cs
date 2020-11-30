using System;

class Numbers
{
    //7.**Операции между числа
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var sign = Console.ReadLine();

        if (b == 0)
        {
            Console.WriteLine("Cannot divide {0} by zero", a);
            return;
        }
        switch (sign)
        {
            case "+":
                Console.Write("{0} + {1} = {2}", a, b, a + b);
                if ((a + b) % 2 == 0) Console.WriteLine(" - even");
                else Console.WriteLine(" - odd"); break;
            case "*":
                Console.Write("{0} * {1} = {2}", a, b, a * b);
                if ((a * b) % 2 == 0) Console.WriteLine(" - even");
                else Console.WriteLine(" - odd"); break;
            case "-":
                Console.Write("{0} - {1} = {2}", a, b, a - b);
                if ((a - b) % 2 == 0) Console.WriteLine(" - even");
                else Console.WriteLine(" - odd"); break;
            case "/":
                Console.WriteLine("{0} / {1} = {2:f2}", a, b, a / b); break;
            case "%":
                Console.WriteLine("{0} % {1} = {2}", a, b, a % b); break;
        }
    }
}

