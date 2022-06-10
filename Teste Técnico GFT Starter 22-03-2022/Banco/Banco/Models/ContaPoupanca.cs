using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public override double Rendimento()
        {
            return saldo * 0.05;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Número da conta: {numero}, Titular: {titular}, Saldo: R$ {saldo + Rendimento()}");
        }
    }
}
