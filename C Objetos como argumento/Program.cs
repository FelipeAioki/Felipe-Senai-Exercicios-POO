using System;
using C_Objetos_como_argumento.Classes;

namespace C_Objetos_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos alguns produtos
            Produto p1 = new Produto(1, "Gta V", 444f);
            Produto p2 = new Produto(2, "Rocket league", 222f);
            Produto p3 = new Produto(3, "Celeste", 666f);
            Produto p4 = new Produto(4, "RedDead", 555f);

            //Adicionamos ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p4);
            carrinho.AdicionarProduto(p3);

            //Mostramos o carrinho
            carrinho.MostrarProduto();
        }
    }
}
