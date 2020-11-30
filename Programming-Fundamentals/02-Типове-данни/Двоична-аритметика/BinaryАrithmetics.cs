using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 5.
Преобразувайте числата в двоична бройна система и извършете действията в двоича бройна система. 
След това преобразувайте резултата в десетична бройна система
12+15=
9+15=
25-10=
45-17=
13*5=
17*3=
36/4=
81/9=
*/
namespace BinaryАrithmetic
{
    class BinaryАrithmetics
    {
        // Функция за обръщане на текст
        static string StringReverse(string str)
        {
            string result = string.Empty;
            for (var i = str.Length - 1; i >= 0; i--)
                result += str[i];
            return result;
        }

        // Конвертиране на десетично в двоично
        static string dec2bin(int n)
        {
            string result = string.Empty;
            while (n > 0)
            {
                result += (n % 2);
                n = n / 2;
            }
            return StringReverse(result);
        }

        // Конвертиране от двоично в десетично
        static int bin2dec(string bin)
        {
            int result = 0, pow = 0;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                var A = int.Parse(bin[i].ToString());
                result += (int)(A * Math.Pow(2, pow));
                pow++;
            }
            return result;
        }

        //---------------------Сумиране на две двоични числа
        static string binplus(string bin1, string bin2)
        {
            // уеднаквяване на дължината на двете числа
            if (bin1.Length > bin2.Length)
            {
                int zeros = bin1.Length - bin2.Length;
                bin2 = new string('0', zeros) + bin2;
            }
            if (bin2.Length > bin1.Length)
            {
                int zeros = bin2.Length - bin1.Length;
                bin1 = new string('0', zeros) + bin1;
            }
            // сумиране
            string bin3 = string.Empty;
            string extraone = "0";
            for (var i = bin1.Length - 1; i >= 0; i--)
            {
                int ones = int.Parse(bin1[i].ToString())
                         + int.Parse(bin2[i].ToString())
                         + int.Parse(extraone.ToString());
                switch (ones)
                {
                    case 0: { bin3 += "0"; extraone = "0"; break; }
                    case 1: { bin3 += "1"; extraone = "0"; break; }
                    case 2: { bin3 += "0"; extraone = "1"; break; }
                    case 3: { bin3 += "1"; extraone = "1"; break; }
                }
            }
            bin3 = StringReverse(bin3);
            if (extraone == "1") bin3 = "1" + bin3;
            return bin3;
        }

        //---------------------Изваждане на две двуични числа

        static string binSubtraction(string bin1, string bin2)
        {

            // уеднаквяване на дължината на двете числа
            if (bin1.Length > bin2.Length)
            {
                int zeros = bin1.Length - bin2.Length;
                bin2 = new string('0', zeros) + bin2;
            }
            if (bin2.Length > bin1.Length)
            {
                int zeros = bin2.Length - bin1.Length;
                bin1 = new string('0', zeros) + bin1;
            }

            // изваждане
            string bin3 = string.Empty;

            for (var i = bin1.Length - 1; i >= 0; i--)
            {
                int ones = int.Parse(bin1[i].ToString())
                         - int.Parse(bin2[i].ToString());
                switch (ones)
                {
                    case 0: { bin3 += "0"; break; }
                    case 1: { bin3 += "1"; break; }
                    case -1:
                        {
                            int distanceNearestNumberToSubtractFrom = 0;
                            for (int j = i; j >= 0; j--)
                            {
                                if (bin1[j] == '1')
                                {
                                    int unchangedNumbersFromBegining = j;
                                    int numberToTakeFrom = 0;
                                    int countUnchangedNumbersToEnd = bin1.Length - (i + 1);
                                    bin1 = bin1.Substring(0, unchangedNumbersFromBegining)
                                        + numberToTakeFrom + new string('1', distanceNearestNumberToSubtractFrom)
                                        + bin1.Substring(i, countUnchangedNumbersToEnd);
                                    bin3 += '1';
                                    break;
                                }
                                distanceNearestNumberToSubtractFrom++;
                            }
                            break;
                        }

                }
            }
            bin3 = StringReverse(bin3);
            return bin3;
        }

        //---------------------Умножение на две двуични числа

        static string binMultiplication(string bin1, string bin2)
        {

            // уеднаквяване на дължината на двете числа
            if (bin1.Length > bin2.Length)
            {
                int zeros = bin1.Length - bin2.Length;
                bin2 = new string('0', zeros) + bin2;
            }
            if (bin2.Length > bin1.Length)
            {
                int zeros = bin2.Length - bin1.Length;
                bin1 = new string('0', zeros) + bin1;
            }

            // умножение
            string bin3 = string.Empty;

            for (var i = bin1.Length - 1; i >= 0; i--)
            {
                string AdditionNumber = string.Empty;
                for (int j = bin1.Length - 1; j >= 0; j--)
                {

                    int ones = int.Parse(bin1[j].ToString())
                         * int.Parse(bin2[i].ToString());
                    switch (ones)
                    {
                        case 0: { AdditionNumber += "0"; break; }
                        case 1: { AdditionNumber += "1"; break; }

                    }

                }

                AdditionNumber = StringReverse(AdditionNumber);
                AdditionNumber += new string('0', bin1.Length - 1 - i);
                bin3 = binplus(bin3, AdditionNumber);
            }

            return bin3;
        }

        //---------------------Деление на две двуични числа

        static string binDivision(string bin1, string bin2)
        {

            // деление
            string bin3 = string.Empty;
            string numbersFromDividend = string.Empty;

            for (var i = 0; i <= bin1.Length - 1; i++)
            {
                numbersFromDividend += bin1[i];
                if (int.Parse(numbersFromDividend) == int.Parse(bin2))
                {
                    numbersFromDividend = string.Empty;
                    bin3 += "1";
                }
                else if (int.Parse(numbersFromDividend) > int.Parse(bin2))
                {
                    numbersFromDividend = binSubtraction(numbersFromDividend, bin2);
                    bin3 += "1";
                }
                else
                {
                    bin3 += "0";
                }

            }
            return bin3;
        }

        // Главна програма
        static void Main(string[] args)
        {
            // 12 
            //+ 
            //15
            int firstNumber = int.Parse(Console.ReadLine());
            string calculationSign = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            if (calculationSign == "+")
            {
                Console.WriteLine(bin2dec(binplus(dec2bin(firstNumber), dec2bin(secondNumber))));
            }
            else if (calculationSign == "-")
            {
                Console.WriteLine(bin2dec(binSubtraction(dec2bin(firstNumber), dec2bin(secondNumber))));
            }
            else if (calculationSign == "*")
            {
                Console.WriteLine(bin2dec(binMultiplication(dec2bin(firstNumber), dec2bin(secondNumber))));
            }
            else if (calculationSign == "/")
            {
                Console.WriteLine(bin2dec(binDivision(dec2bin(firstNumber), dec2bin(secondNumber))));
            }

        }
    }
}