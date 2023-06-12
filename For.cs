//inclusão de bibliotecas
using System;

//classe do programa
public class Program
{
    //abertura do código principal
    public static void Main()
    {
        //declaraçãod e variável
        int num;

        //interface do usuário
        Console.Write("Digite um numero inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        //interface do usuário
        Console.Write("Os primeiros " + num + " numeros pares sao: ");
        
        //ação da condicional
        for (int i = 2; i <= num * 2; i += 2)
        {
            //interface do usuário
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
