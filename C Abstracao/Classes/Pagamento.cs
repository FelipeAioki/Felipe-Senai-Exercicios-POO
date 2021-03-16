using System;

namespace C_Abstracao.Classes
{
    public abstract class Pagamento
    {
        //Atributos

        private DateTime data;
        private DateTime vencimento;
        protected float valor;

        //Métodos
        public string Cancelar(){
            return "";
        }
    }
}