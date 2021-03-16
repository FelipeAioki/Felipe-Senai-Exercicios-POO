namespace C_Herancas.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string documento;
        public string rg;

        public bool ValidarCpf(){
            if( documento != ""){
                return true;
            }
            return false;
        }
    }
}