using System;

namespace Primeira_atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(console.readline());

            if(idade >= 18){
                console.WriteLine("Você gostaria de participar do time de CS-GO? - Sim ou Não");
                string resposta = console.readline();
                if( resposta == "SIM"){
                    console.writeLine("Compareça na secretaria - Falar com SARA");
                }else{
                    console.writeLine("Beleza! passar bem.");
                }
            }
            else{
                console.writeLine("Você gostaria de participar do time de LOL? SIM OU NÃO");
                string resposta = console.readline();
                if(resposta == "SIM"){
                    console.writeLine("Compareça a secretaria - Falar com Jucelino");
                }else{
                    console.writeLine("Muito obrigado!");
                    }
                }
            }
        }
    }
}