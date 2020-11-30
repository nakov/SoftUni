using System;
using System.Collections.Generic;
using System.Linq;

class Supermarket
{
    public static void Main()
    {
        var productNameQuantityDict = new Dictionary<string, long>();
        var productNamePriceDict = new Dictionary<string, double>();

        var inputLine = Console.ReadLine();

        while (inputLine != "stocked")
        {
            var token = inputLine
                .Trim()
                .Split(' ')
                .ToArray();

            var productName = token[0];
            var productPrice = double.Parse(token[1]);
            var productQuantity = long.Parse(token[2]);

            if (!productNameQuantityDict.ContainsKey(productName))
            {
                productNameQuantityDict[productName] = 0;
                productNamePriceDict[productName] = productPrice;
            }

            productNameQuantityDict[productName] += productQuantity;
            productNamePriceDict[productName] = productPrice;

            inputLine = Console.ReadLine();
        }

        var grandTotal = 0d;
        foreach (var product in productNamePriceDict)
        {
            foreach (var productQuantity in productNameQuantityDict)
            {
                if (productQuantity.Key == product.Key)
                {
                    var totalPrice = product.Value * productQuantity.Value;
                    grandTotal += totalPrice;
                    Console.WriteLine($"{product.Key}: " +
                                      $"${product.Value:f2} * {productQuantity.Value} = ${totalPrice:f2}");
                }
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:f2}");
    }
}