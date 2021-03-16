using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja: \n Soma, Subtração, Divisão, Multiplicação");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º Número");
            float num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2º Número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(operacao){
                case "Soma":
                resultado = num1+num2;
                break;

                case "subtracao":
                resultado = num1-num2;
                break;

                case "divisao":
                resultado = num1/num2;
                break;

                case "multiplicacao":
                resultado = num1*num2;
                break;
                
                default:
                Console.WriteLine("Operação invalida");
                break;
            }
            Console.WriteLine("Seu resultado é "+resultado);
        }
    }
}
