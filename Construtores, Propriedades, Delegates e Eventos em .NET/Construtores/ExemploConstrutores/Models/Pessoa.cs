namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Cristiano"; // Só pode ser alterado aqui ou...
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty; // ...ou aqui
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome; // ...ou aqui
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {nome} {sobrenome}");
        }
    }
}

