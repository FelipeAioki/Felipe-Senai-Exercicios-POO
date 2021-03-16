using System;
using System.Collections.Generic;

namespace C_Objetos_como_argumento.Classes
{
    public class Carrinho
    {
        //Criamos uma propriedade pra guardar o valor total do carrinho
        public float ValorTotal { get; set; }

        //Representará nosso carrinho
        List<Produto> carrinho = new List<Produto>();

        //Adicionar ao carrinho
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        //Remove produto
        public void RemoveProduto(Produto produto){
            carrinho.Remove(produto);
        }
        public void MostrarProduto()
        {
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"R$ {p.Preco.ToString("n2")} - {p.Nome} ");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        //Criamos um metodo para calcular o total da compra:
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                System.Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")} ");
            }else{
                System.Console.WriteLine($"Seu carrinho ainda está vazio! ");
            }
            Console.ResetColor();
        }
    }
}