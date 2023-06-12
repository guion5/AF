//incluir biblioteca
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking3
{
    //classe do programa
    class Program
    {
        //abertura de código
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Soma");
            Console.WriteLine("2.Substração");
            Console.WriteLine("3.Multiplicação");
            Console.WriteLine("4.Divisão");

            //Interface de usuário
            Console.Write("Escolha uma operação (1-4):");
            int ch = Int32.Parse(Console.ReadLine());

            //declaração de variáveis
            int a, b, c;

            //condicionais switch e cases
            switch (ch)
            {
                case 1:
                    //Interface de usuário
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    //cálculo com os valores atribuidos as variáveis
                    c = a + b;
                    //Interface de usuário com o resultado do cálculo
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 2:
                    //Interface de usuário
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    //cálculo com os valores atribuidos as variáveis
                    c = a - b;
                    //Interface de usuário com o resultado do cálculo
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 3:
                    //Interface de usuário
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                    //cálculo com os valores atribuidos as variáveis
                    c = a * b;
                    //Interface de usuário com o resultado do cálculo
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                case 4:
                    //Interface de usuário
                    Console.Write("Insira o primeiro valor:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Insira o segundo valor:");
                    b = Convert.ToInt32(Console.ReadLine());
                     //cálculo com os valores atribuidos as variáveis
                    c = a / b;
                    //Interface de usuário com o resultado do cálculo
                    Console.WriteLine("Resultado = {0}", c);
                    break;
                default:
                    //Interface de usuário
                    Console.WriteLine("Escolha inválida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
