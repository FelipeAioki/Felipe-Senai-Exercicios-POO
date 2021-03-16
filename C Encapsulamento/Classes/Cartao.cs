namespace C_Encapsulamento.Classes
{
    public class Cartao
    {
        //Declaração dos atributos
        
        private string numero;
        private string bandeira = "Bandeira";
        public string Bandeira{
            get{return bandeira;}
        }
        protected string token = "qwertyui";
        private string cvv;
        protected float limite = 5000;

        //Declaração dos metodos

        public string RegistrarCompra(bool invalido){
            return "";
        }
        private bool ValidarCompra(float saldo){
            return true;
        }
        protected string ValidarToken(string token){
            return "";
        }
    }
}