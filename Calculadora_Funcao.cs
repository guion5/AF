using System;

public class Program
{
    public static float Soma(float a, float b)
    {
        float resultado1;
        resultado1 = a + b;
        return resultado1;
    }

    public static float Subt(float a, float b)
    {
        float resultado2;
        resultado2 = a - b;
        return resultado2;
    }

    public static float Mult(float a, float b)
    {
        float resultado3;
        resultado3 = a * b;
        return resultado3;
    }

    public static float Divi(float a, float b)
    {
        float resultado4;
        resultado4 = a / b;
        return resultado4;
    }

    public static void Main()
    {
        Console.WriteLine(Soma(3, 5));
        Console.WriteLine(Subt(3, 5));
        Console.WriteLine(Mult(3, 5));
        Console.WriteLine(Divi(3, 5));
    }
}
