using System;
using C_Polimorfismo.Classes;

namespace C_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();

            System.Console.WriteLine(jogador.Correr());
        }
    }
}
