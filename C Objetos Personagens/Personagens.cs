namespace C_Objetos_Personagens
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;


        public string atacar(){
                return "Ataque de fogo!";
        }

        public string Defender(){
                return "Não foi dessa vez!";
        }
    }
}