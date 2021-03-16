using System;

namespace terceira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salário");
            int salario = int.Parse( Console.ReadLine());
            double dinheiro = salario * 1.30;
            
        if(salario >= 500){
            if( salario == 500){
                    Console.WriteLine("Você não tem beneficio");
                }
            else{
                Console.WriteLine("Você receberá " +dinheiro);
            }
        }
    }
}
