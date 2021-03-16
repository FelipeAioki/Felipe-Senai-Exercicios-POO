using System;

namespace C_Polimorfismo_Overload.Classes
{
    public class Funcionarios
    {
        public string[] lista = {"Paulo","Tsuka","Priscila","Fernanda"};

        //Mostra todos os nomes do array
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
        //Mostra somente o dado que está no inicio do array
        public void Mostrar(int indice){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(lista[indice]);
            Console.ResetColor();
        }
        //Fazemos uma busca no array, para verificar se os textos coincidem
        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                if(item == busca){
                    Console.WriteLine("Resultado da busca"+item);
                }
                
                Console.ResetColor();
            }
        }
    }
}