using System;

namespace BoatSimulator
{
    /*
    Имате задача да направите симулатор на състезание с лодки. Ще получите две букви, които ще обозначават двете лодки. 
    След това ще получите n случайни  низа. Всеки низ на нечетен ред показва скоростта на първата лодка, 
    а на четен ред – скоростта на втората лодка. Лодката се придвижва с толкова позиции, 
    колкото е дължината на съответния низ. Лодката, която първа стигне до 50-та позиция е победител. 
    Лодките могат да се ъпгрейдват, което ще рече, че когато получим низа “UPGRADE” ще добавим 3 към ASCII кодовете 
    и на двата знака на лодките и след това получените знаци ще се използват за визуализиране на лодките. 
    Ако получите “UPGRADE”, лодките НЕ се мърдат.
    Ако една от лодките стигне до 50 – изведете знака на победителя и спрете да приемате входни данни. 
    Ако нито една от лодките не стигне до 50 – изведете тази, която е успяла да стигне до най-голямата позиция.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            byte numberOfLines = byte.Parse(Console.ReadLine());
            byte positionBoat1 = 0;
            byte positionBoat2 = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        positionBoat1 += (byte)currentCommand.Length;
                        if (positionBoat1 >= 50)
                        {
                            break;
                        }
                    }
                    else
                    {
                        positionBoat2 += (byte)currentCommand.Length;
                        if (positionBoat2 >= 50)
                        {
                            break;
                        }
                    }

                }
            }

            Console.WriteLine(positionBoat1 > positionBoat2 ? boat1 : boat2);
        }
    }
}
