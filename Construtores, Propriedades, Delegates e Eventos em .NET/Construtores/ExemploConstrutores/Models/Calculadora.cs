namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        // Delegate
        public delegate void DelegateCalculadora();

        // Evento
        public static event DelegateCalculadora EventoCalculadora; // Evento que outros objetos podem se inscrever

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null) // verifica se tem inscritos no evento
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora(); // Executa o evento - métodos inscritos
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}