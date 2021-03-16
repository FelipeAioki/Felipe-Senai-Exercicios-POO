using System;

namespace C_Objetos_Personagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Felipe";
            objetoPersonagem1.armadura = "Traje";
            objetoPersonagem1.idade = 18;

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Marianna";
            objetoPersonagem2.armadura = "Pijama";
            objetoPersonagem2.idade = 4;

            System.Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.atacar()} ");
            System.Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()} ");
        }
    }
}
