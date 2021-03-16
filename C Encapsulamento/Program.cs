using System;
using C_Encapsulamento.Classes;

namespace C__Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quando a classe não estiver sendo usada, apertamos ( Ctrl + . ) para atribuirmos ao codigo.
            Mastercard m = new Mastercard();

            m.Parcelas = 12;

            System.Console.WriteLine(m.Bandeira);
        }
    }
}
