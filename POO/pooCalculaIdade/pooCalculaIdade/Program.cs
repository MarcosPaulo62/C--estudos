using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula idade de uma pessoa");
            Pessoa p = new Pessoa();

            Console.WriteLine("Nome da pessoa: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Ano de nascimento da pessoa: ");
            p.AnoNascimento = int.Parse(Console.ReadLine());

            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
