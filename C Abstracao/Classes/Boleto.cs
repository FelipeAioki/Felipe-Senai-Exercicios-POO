using System;

namespace C_Abstracao.Classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        private string codigoDeBarras;

        //Métodos
        public void Registrar(){
            System.Console.WriteLine("Registrado");
        }
        public override string Desconto (int valor)
        {
            return"";
        }
    }
}