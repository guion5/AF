//inclusão de biblioteca
using System;

//classe do programa
public class Program
{
    //programa principal - abertura do código
    public static void Main()
    {
        //declaração de variável
        int num;
        
        //ação inicial
        do
        {
            //interface do usuário para inserir valor
            Console.Write("Digite um numero entre 1 e 10: ");
            num = int.Parse(Console.ReadLine());
          //condicional para valores menores que 1 ou maiores que 10  
        } while (num < 1 || num > 10);

        //interface do usuário com a resposta
        Console.WriteLine("Você digitou o número " + num + ".");
    }
}
