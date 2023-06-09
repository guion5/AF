using System;

public class Program
{
    public static void Main()
    {
        int num;

        Console.Write("Digite um numero inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Os primeiros " + num + " numeros pares sao: ");
        
        for (int i = 2; i <= num * 2; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
