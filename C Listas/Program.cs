using System;
using System.Collections.Generic;

namespace C_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Champs = new List<string>();
            Champs.Add("Yone");
            Champs.Add("Yasuo");
            Champs.Add("Shen");
            Champs.Add("Kindreds");

            System.Console.WriteLine(Champs.Count);  //Count conta quantos itens temos na lista.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            bool resposta = Champs.Contains("Shen");  //Countais retorna um valor bool caso o item existir ou não.

            if(resposta == true){
                System.Console.WriteLine("Campeão encontrado");
            }else{
                System.Console.WriteLine("Campeão não encontrado");
            }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Champs.Remove("Kindreds");  //Remove remove algo da lista
            foreach(var item in Champs){
                System.Console.WriteLine(item);
            }

            
        }
    }
}
