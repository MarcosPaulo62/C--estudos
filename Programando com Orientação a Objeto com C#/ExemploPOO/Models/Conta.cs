namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;
        public abstract void Creditar(double valor); // classe filha é obrigada a sobrescrever

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}