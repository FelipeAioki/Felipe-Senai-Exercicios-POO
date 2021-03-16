using System;
using C_Polimorfismo_Overload.Classes;

namespace C_Polimorfismo_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamos nossa classe funcionario
            Funcionarios fun = new Funcionarios();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(2);

            Console.Beep();

        }
    }
}
