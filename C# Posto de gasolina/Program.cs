using System;

namespace C__Posto_de_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tipo de combustivel");
            System.Console.WriteLine("A - Alcool");
            System.Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            System.Console.WriteLine("Digite a quantidade:");
            float quantidade = float.Parse(Console.ReadLine());
            float desconto;

            switch(combustivel.ToLower())
            {
                case "a":
                    if(quantidade>20){
                    desconto = 0.05f;
                    }else{
                    desconto = 0.03f;
            }
                
                float desconto1 = (quantidade*4.9f) * desconto;

                System.Console.WriteLine($"Valor a ser pago:{desconto1}");

            }
        }
    }
}
