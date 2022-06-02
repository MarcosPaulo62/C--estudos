using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_GFT_08_02_2022.Interfaces;

namespace Teste_GFT_08_02_2022.Models
{
    internal class Livro : Produto, IImposto
    {
        protected string autor;
        protected string tema;
        protected int qtdPag;

        public Livro()
        {
            autor = "";
            tema = "";
            qtdPag = 0;
        }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public void calculaImposto()
        {
            if (tema == "educativo")
                Console.WriteLine($"Livro educativo não tem imposto: {nome}.");
            else
                Console.WriteLine($"R$ {(preco * 0.1).ToString("F1")} de impostos sobre o livro {nome}.");
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public int QtdPag
        {
            get { return qtdPag; }
            set { qtdPag = value; }
        }
    }
}
