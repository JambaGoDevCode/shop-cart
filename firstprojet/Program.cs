using System;
/*
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int number = 2;
        float price = 3.99f;

        Console.WriteLine(number + price);
    }
}
*/

/**
public class FirstApp
{
    public static void Main()
    {
        int a = 1;
        int b = 3;

        a = 3;
        int c = a + b;
        string nome = "João";

        Console.WriteLine(nome + " " + "Resultado é: " + c);
    } 
}
*/

public class MyShopCart
{
    public static void Main()
    {
        float iva = 14f;
        float productA = 153.99f;
        float productB = 11.99f;
        float productC = 5.75f;

        float summed = productA + productB + productC;
        float totalTax = (summed / 100) * iva;

        summed += totalTax;

        Console.WriteLine("Total price is: " + summed);
    }
}

