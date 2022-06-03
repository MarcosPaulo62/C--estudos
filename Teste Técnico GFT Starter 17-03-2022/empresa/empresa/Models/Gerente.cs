using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.Models
{
    internal class Gerente : Funcionario
    {
        public Gerente()
        {
        }

        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificacao()
        {
            return Salario + 10000;
        }

        public override string ToString()
        {
            return $"O gerente {Nome} tem {Idade} anos e recebe R$ {Bonificacao().ToString("F1")}";
        }
    }
}
