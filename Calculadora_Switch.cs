using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Substração");
            Console.WriteLine("3.Multiplicação");
            Console.WriteLine("4.Divisão");

            Console.Write("Escolha uma operação (1-4):");
            int ch = Int32.Parse(Console.ReadLine());

            int a, b, c;

            switch (ch)
            {
                case 1:
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 2:
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 3:
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 4:
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    break;
            }

            Console.ReadKey();
        }
    }
}