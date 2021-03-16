using System;

namespace C__ARR4Y_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            float[] media = new float[5];
            float[] notas = new float [4];


            for (var i = 0; i < nomes.Length; i++)
            {
                System.Console.WriteLine("Digite o nome");
                nomes[i] = Console.ReadLine();
                
            }
            Console.ForegroundColor = ConsoleColor.Red;

            //laços condicionais

            foreach (string  nome in nomes){
                System.Console.WriteLine(nome);

            }
            {
                
            }
        }
    }
}
