using System;
using System.Globalization;

public class Program
{
    public static float Soma(float a, float b)
    {
        float Soma = a + b;
        //resultado do calculo das variáveis (a,b)
        return Soma;
    }

    //declaração de variávels
    public static float Subt(float a, float b)
    {
        float Subt = a - b;
        //resultado do calculo das variáveis (a,b)
        return Subt;
    }

    //declaração de variávels
    public static float Mult(float a, float b)
    {
        float Mult = a * b;
        //resultado do calculo das variáveis (a,b)
        return Mult;
    }

    //declaração de variávels
    public static float Divi(float a, float b)
    {
        float Divi = a / b;
        //resultado do calculo das variáveis (a,b)
        return Divi;
    }
    //abertura do código
    static void Main(string[] args)
    {
        float soma = Soma(3, 5);
        float subt = Subt(3, 5);
        float mult = Mult(3, 5);
        float divi = Divi(3, 5);

        {
            //interface do usuário com o resultado do primeiro calculo (valores fixos)
            Console.WriteLine(soma.ToString(CultureInfo.InvariantCulture));
            //interface do usuário com o resultado do segundo calculo (valores fixos)
            Console.WriteLine(subt.ToString(CultureInfo.InvariantCulture));
            //interface do usuário com o resultado do terceiro calculo (valores fixos)
            Console.WriteLine(mult.ToString(CultureInfo.InvariantCulture));
            //interface do usuário com o resultado do quarto calculo (valores fixos)
            Console.WriteLine(divi.ToString(CultureInfo.InvariantCulture));
        }
    }
}



