using System.Collections.Generic;
using System.IO;

namespace C_Aplicando_MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
        string pasta = PATH.Split("/")[0];
        
        //Verificamos se a pasta não existe e criamos nessa condição
            if(!Directory.Exists(pasta))
            {
            Directory.CreateDirectory(pasta);
            }
        
        if(!File.Exists(PATH)){
            File.Create(PATH);
        }
    }            
    public List<Produto> Ler(){
        List<Produto> produtos = new List<Produto>();
        
        //Pegar as informações do CSV
        string[] linhas = File.ReadAllLines(PATH);

        foreach(string item in linhas)
        {
        //Separar atributos pelo ;

        string[] atributos = item.Split(";");
        //Criamos um produto vazio para podermos colocar na lista final

        Produto prod = new Produto();
        prod.Codigo     = int.Parse(atributos[0]);
        prod.Nome       = atributos[1];
        prod.Preco      = float.Parse(atributos[2]);

        produtos.Add(prod);

        }
        return produtos;
    }
}
}
