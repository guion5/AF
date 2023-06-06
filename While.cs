using System;
using System.Globalization;

namespace Course
{
    public class While
    {
        public static void main(string[] args)
        {
            double num, i = 1;
            Console.WriteLine("Digite um número inteiro positivo: ");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (i <= num)
            {
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture) + ", ");
                i++;
            }
        }
    }
}
