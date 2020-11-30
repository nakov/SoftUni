using System;
using System.Linq;

namespace UpgradedStorehouse
{
    /*
     За тази задача можете да използвате вашето решение от задачата за склада. 
    Този път само масива, съдържащ имената и масива, съдържащ цените ще имат същата дължина. 
    Ако в масива с количествата няма  индекс, който отговаря на името, трябва да се приеме количество 0. 
    Освен това продуктите, които получавате след масиви ще съдържа не само низ за името, но 
    и дълга, който е, количеството, което трябва да се поръча.  Ако имате достатъчно количество, 
    да се изчисли общата цена чрез умножаване на поръчаните количества по цената и да я отпечатате в следния формат:
    {име на продукта} x {поръчано количество} струва {обща цена на поръчката}
    Форматирайте цената до втория знак след десетичната запетая. Не забравяйте да намалите количеството на продукта. Ако нямате необходимото количество изведете: 
    We do not have enough {product name}
     */
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var product = Console.ReadLine().Split(' ');
            string productName = product[0];
            int size = names.Length;

            var allQuantities = FillMissedQuanitites(quantities, size);

            while (productName != "done")
            {
                long searchedQuantity = long.Parse(product[1]);

                int indexOfProduct = Array.IndexOf(names, productName);
                string name = names[indexOfProduct];
                decimal price = prices[indexOfProduct];
                long quantity = 0;

                if (indexOfProduct >= 0 && indexOfProduct < size)
                {
                    quantity = allQuantities[indexOfProduct];
                }

                if (quantity > 0 && quantity - searchedQuantity >= 0)
                {
                    decimal totalPriceOfOrder = searchedQuantity * price;
                    Console.WriteLine($"{name} x {searchedQuantity} costs {totalPriceOfOrder:f2}");
                    allQuantities[indexOfProduct] -= searchedQuantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {name}");
                }
                product = Console.ReadLine().Split(' ');
                productName = product[0];
            }
        }
        static long[] FillMissedQuanitites(long[] quantities, int size)
        {
            var allQuantities = new long[size];
            int oldArraySize = quantities.Length;

            for (int index = 0; index < size; index++)
            {
                if (index >= oldArraySize)
                {
                    allQuantities[index] = 0L;
                }
                else
                {
                    allQuantities[index] = quantities[index];
                }
            }
            return allQuantities;
        }
    }
}
