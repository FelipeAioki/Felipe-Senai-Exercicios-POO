using System;
using C_Interfaces.Classes;

namespace C_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
        
            Produto p1 = new Produto();
            p1.Codigo  = 123;
            p1.Nome    = "Playstation 4";
            p1.Preco   = 2000;

            Produto p2 = new Produto();
            p2.Codigo  = 345;
            p2.Nome    = "Xbox series X";
            p2.Preco   = 3000;

            Produto p3 = new Produto();
            p3.Codigo  = 678;
            p3.Nome    = "Nitendo switch";
            p3.Preco   = 4000;

            Console.ForegroundColor = ConsoleColor.Red;

            carrinho.Cadastrar(p1);
            carrinho.Listar();
            carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Blue;
            
            carrinho.Alterar(p1.Codigo,p3);
            carrinho.Listar();

            Console.ResetColor();
        }
    }
}
