//inclusão de biblioteca
using System;

//classe do programa
public class Program
{
    //declaração de variável
    public static float Soma(float a, float b)
    {
        float resultado1;
        //cálculo 1
        resultado1 = a + b;
        return resultado1;
    }

    //declaração de variável
    public static float Subt(float a, float b)
    {
        float resultado2;
        //cálculo 2
        resultado2 = a - b;
        return resultado2;
    }

    //declaração de variável
    public static float Mult(float a, float b)
    {
        float resultado3;
        //cálculo 3
        resultado3 = a * b;
        return resultado3;
    }

    //declaração de variável
    public static float Divi(float a, float b)
    {
        float resultado4;
        //cálculo 4
        resultado4 = a / b;
        return resultado4;
    }

    //programa principal
    public static void Main()
    {
        //interface do usuário
        Console.WriteLine(Soma(3, 5));
        Console.WriteLine(Subt(3, 5));
        Console.WriteLine(Mult(3, 5));
        Console.WriteLine(Divi(3, 5));
    }
}
