namespace Mentoria_GFT
{
    public class NumeroInverso
    {
        public static void numeroReverso()
        {
            do
            {
                System.Console.WriteLine("Informe o valor (deverá conter 4 dígitos)");
                int numero = int.Parse(Console.ReadLine());
                string numeroString = numero.ToString();
                string textoInvertido = new string(numeroString.Reverse().ToArray());
                if (numero >= 1000 && numero <= 9999)
                {
                    System.Console.WriteLine($"Número invertido: {textoInvertido}");
                    break;
                }
                else
                    System.Console.WriteLine("Número inválido! Tente novamente.");
                
            } while (true);
        }
    }
}