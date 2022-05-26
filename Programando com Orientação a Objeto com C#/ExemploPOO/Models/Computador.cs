namespace ExemploPOO.Models
{
    public class Computador // : System.Object <- isso é implicito, as classes já herdam de Object automaticamente
    {
        public override string ToString() // sobrescrevendo classe herdada
        {
            return "Sou uma classe computador";
        }
    }
}