namespace C_POO_static
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.24f;

        public static float RealParaDolar(float valorRS){
                    return valorRS / CotacaoDolar;
        }
        public static float DolarParaReal(float ValorUS){
                    return CotacaoDolar * ValorUS;
        }
    }
}