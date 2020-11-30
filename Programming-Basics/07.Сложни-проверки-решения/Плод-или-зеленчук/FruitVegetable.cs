using System;

class FruitVegetable
{
    //4.Плод или зеленчук
    static void Main()
    {
        var produkt = Console.ReadLine();
        switch (produkt)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes": Console.WriteLine("fruit"); break;
            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot": Console.WriteLine("vegetable"); break;
            default: Console.WriteLine("unknown"); break;
        }
        /*
                    if(produkt=="bananna" || produkt=="apple" ||
                       produkt=="lemon" || produkt=="cherry" ||
                       produkt=="grapes" || produkt=="cherry") 
                          Console.WriteLine("fruit");
                    else if(produkt=="tomato" || produkt=="cucumber" ||
                             produkt=="pepper" || produkt=="carrot")
                          Console.WriteLine("vegetable");
                    else Console.WriteLine("unknown")
        */
    }
}

