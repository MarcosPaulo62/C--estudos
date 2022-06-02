using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private string nome;

        public string Nome
        {
            get { return  nome; }
            set {  nome = value.ToUpper(); }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Ano de nascimento: {AnoNascimento}");
            Console.WriteLine($"Idade: {CalcularIdade()}");
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - AnoNascimento;
            return idade;
        }

    }
}
