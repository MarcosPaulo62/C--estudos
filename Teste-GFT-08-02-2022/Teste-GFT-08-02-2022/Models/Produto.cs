using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_GFT_08_02_2022.Models
{
    public abstract class Produto
    {
        protected string nome;
        protected double preco;
        protected int qtd;

        public Produto()
        {
            nome = "";
            preco = 0;
            qtd = 0;
        }
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }
    }
}
