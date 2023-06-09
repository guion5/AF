using System;

public class Program
{
    public static void Main()
    {
        int num, i = 1;
        Console.Write("Digite um numero inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        
        while (i <= num)
        {
            Console.Write(i + " ");
            i++;
        }
    }
}
