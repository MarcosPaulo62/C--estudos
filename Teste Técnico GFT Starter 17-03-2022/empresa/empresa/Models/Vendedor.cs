using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa.Models
{
    internal class Vendedor : Funcionario
    {
        public Vendedor()
        {
        }

        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override double Bonificacao()
        {
            return Salario + 3000;
        }
        public override string ToString()
        {
            return $"O vendedor {Nome} tem {Idade} anos e recebe R$ {Bonificacao().ToString("F1")}";
        }
    }
}
