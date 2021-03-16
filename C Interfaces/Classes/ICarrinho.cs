namespace C_Interfaces.Classes
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int cod, Produto produto);
         void Deletar(Produto produto);
    }
}