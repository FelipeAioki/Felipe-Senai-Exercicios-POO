using System;
using C_Aplicando_MVC.Controllers;
using C_Aplicando_MVC.Models;

namespace C_Aplicando_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtocontroller = new ProdutoController();
            produtocontroller.MostrarProdutos();
        }
    }
}
