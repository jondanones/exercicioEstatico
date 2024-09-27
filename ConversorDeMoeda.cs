namespace exercicioEstatico
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double Operacao(double cotacao, double quantidade)
        {
            return (quantidade * cotacao) + (IOF * (cotacao * quantidade));
        }
    }
}
