using System;

public class Program
{
    public static void Main()
    {
        int num;
        
        do
        {
            Console.Write("Digite um numero entre 1 e 10: ");
            num = int.Parse(Console.ReadLine());
        } while (num < 1 || num > 10);

        Console.WriteLine("Você digitou o número " + num + ".");
    }
}
