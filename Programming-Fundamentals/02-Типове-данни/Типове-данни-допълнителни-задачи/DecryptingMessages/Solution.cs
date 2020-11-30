using System;

namespace DecryptingMessages
{
    /*
    Ще получите ключ (цяло число) и n знака след това. 
    Добавете ключа към всеки то знаците и ги слепете към съобщението. 
    Накрая изведете полученото съобщение. 
     */
    class Solution
    {
        static void Main(string[] args)
        {
            byte decriptionKey = byte.Parse(Console.ReadLine());
            byte charactersCount = byte.Parse(Console.ReadLine());
            string message = "";

            while (charactersCount > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + decriptionKey)).ToString();

                charactersCount--;
            }

            Console.WriteLine(message);
        }
    }
}
