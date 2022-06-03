using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.Models
{
    internal class Funcionario
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public virtual double Bonificacao()
        {
            return salario;
        }

        public override string ToString()
        {
            return $"O funcionário {Nome} tem {Idade} anos e recebe R$ {Bonificacao().ToString("F1")}";
        }

    }
}
