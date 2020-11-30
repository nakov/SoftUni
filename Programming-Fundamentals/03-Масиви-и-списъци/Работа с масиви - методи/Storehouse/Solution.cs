using System;
using System.Linq;

namespace Storehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split(' ');

            while (true)
            {
                string inputProduct = Console.ReadLine();
                int productPosition = FindProductPosition(inputProduct, products);
                if (productPosition == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{products[productPosition]} costs: {prices[productPosition]}; Available quantity: {quantity[productPosition]}");
                }

            }
        }
        static int FindProductPosition(string inputProduct, string[] products)
        {
            var position = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (inputProduct == products[i])
                {
                    return position = i;
                }

            }
            return position = -1;
        }
    }
}
