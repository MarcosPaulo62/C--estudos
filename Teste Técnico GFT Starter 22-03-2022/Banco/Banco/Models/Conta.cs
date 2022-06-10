using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    public abstract class Conta
    {
        protected int numero { get; set; }
        protected string titular { get; set; }
        protected double saldo { get; set; }

        public virtual double Rendimento()
        {
            return saldo;
        }
    }
}
