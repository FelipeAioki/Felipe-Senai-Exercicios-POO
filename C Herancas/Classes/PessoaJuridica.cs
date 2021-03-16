namespace C_Herancas.Classes
{
    public class PessoaJuridica
    {
        public string cnpj;
        public string incricaoEstadual;

        public bool ValidarCnpj(string documento){
            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}