using System.Collections.Generic;
using C_Aplicando_MVC.Models;
using C_Aplicando_MVC.Views;

namespace C_Aplicando_MVC.Controllers
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
    }
}