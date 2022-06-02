using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade {
            get { return idade; }
            set {
                if (idade >= 0)
                    idade = value;
                else
                    idade = 0;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }

    }
}
