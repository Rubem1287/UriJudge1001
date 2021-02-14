using System;

namespace Soma_18_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, x;

            Console.WriteLine();
            Console.Write("Digite o primeiro número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o segundo número : ");
            b = int.Parse(Console.ReadLine());

            x = a + b;

            Console.WriteLine();
            Console.Write("X = "+x);

        }
    }
}
