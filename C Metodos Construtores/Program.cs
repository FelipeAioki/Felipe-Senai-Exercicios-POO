using System;
using C_Metodos_Construtores.Classes;

namespace C_Metodos_Construtores
{
    class Program : Pessoas
    {
        public Program(string fisrtName, string lastName) : base(fisrtName, lastName)
        {
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu Sobrenome:");
            string sobrenome = Console.ReadLine();

            Pessoas Felipe = new Pessoas(nome,sobrenome);

            System.Console.WriteLine($"Bem vindo {nome} {sobrenome}");
        }
    }
}
