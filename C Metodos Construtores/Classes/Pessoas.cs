namespace C_Metodos_Construtores.Classes
{
    public class Pessoas
    {
        private string sobreNome;

        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }

        private string nome;

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        public Pessoas(string fisrtName, string lastName){
            sobreNome = lastName;
            Nome = fisrtName;
        }
        public Pessoas(string fisrtName){
            nome = fisrtName;
        }
    }
}