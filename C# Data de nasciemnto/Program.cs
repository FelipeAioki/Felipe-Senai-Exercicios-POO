using System;

namespace C__Data_de_nasciemnto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento");
            int data1 = int.Parse(Console.ReadLine());

            int data2 = 2020;

            int idade = data2 - data1;

        if(idade >16);
        {
        System.Console.WriteLine("Você tem mais de 16 anos, pode votar");
       
               else
        {
            System.Console.WriteLine("Você não pode votar");
        }
       }

    }
}
