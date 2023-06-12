//inclusão de bibliotecas
using System;

//classe do programa
public class Program
{
    //abertura do código principal
    public static void Main()
    {
        //declaração de variável
        int num, i = 1;
        //interface do usuário
        Console.Write("Digite um numero inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        
        //ação do condicional
        while (i <= num)
        {
            //interface do usuário com a contagem
            Console.Write(i + " ");
            i++;
        }
    }
}
