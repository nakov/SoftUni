using System;

namespace SentenceTheThief
{
    /*
    В предната задача хванахме крадеца, сега обаче трябва и да изчислим неговата присъда.
    Неговата присъда е равна на броя на пътите, в които неговото ID препълва sbyte. 
    Закръглете нагоре годините към най-близката цяла стойност (5.01  6).
    Пример: Ако id-то е 5251, това значи, че присъдата ще бъде равна на: 5251 / 127 = 41.35 години. 
    Закръглено това са 42 години.
    Забележете, че id-то може да бъде отрицателно и да препълни отрицателната граница на sbyte.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            string dataTypeThiefID = Console.ReadLine();
            byte countOfIDs = byte.Parse(Console.ReadLine());
            long thiefID = long.MinValue;
            while (countOfIDs > 0)
            {
                string currentID = Console.ReadLine();
                if (dataTypeThiefID == "sbyte")
                {
                    try
                    {
                        long currentIDNum = sbyte.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "int")
                {
                    try
                    {
                        long currentIDNum = int.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "long")
                {
                    try
                    {
                        long currentIDNum = long.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }

                countOfIDs--;
            }

            if (thiefID > 0)
            {
                long sentence = (long)Math.Ceiling((decimal)thiefID / sbyte.MaxValue);
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)thiefID / sbyte.MinValue);
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
        }
    }
}
