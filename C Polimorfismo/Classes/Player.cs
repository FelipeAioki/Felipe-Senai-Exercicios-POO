namespace C_Polimorfismo.Classes
{
    public abstract class Player
    {
        private string velocidade;

        private float forcaPulo;
        
        public virtual string Correr(){
            return"Correndo na velocidade de 1x";
        }
    }
}