using System;

namespace C_POO_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite o valor a ser convertido");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine(Conversor.DolarParaReal(num));
            System.Console.WriteLine(Conversor.RealParaDolar(num));
        }
    }
}
