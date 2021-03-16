using System;

namespace Segunda_atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite sua idade."); int idade = int.Parse( Console.ReadLine());
            
            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;
            
            
            Console.WriteLine("A quantidade de meses é: " +meses);
            Console.WriteLine("A quantidade de dias é: " +dias);
            Console.WriteLine("A quantidade de horas é: " +horas);
            Console.WriteLine("A quantidade de minutos é: " +minutos);
        }
    }
}
