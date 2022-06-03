using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leitorLivros.Models
{
    internal class Leitor
    {
        protected string nome;
        protected Livro livroFavorito = new Livro();
        protected List<Livro> estanteLivros = new List<Livro>();

        public Leitor()
        {
        }

        public Leitor(string nome, Livro livroFavorito)
        {
            this.nome = nome;
            this.livroFavorito = livroFavorito;
            estanteLivros.Add(livroFavorito);
        }

        public Leitor(string nome, Livro livroFavorito, List<Livro> estanteLivros)
        {
            this.nome = nome;
            this.livroFavorito = livroFavorito;
            this.estanteLivros = estanteLivros;
            this.estanteLivros.Add(livroFavorito);
        }   

        public void AdicionarLivro(Livro livro)
        {
            estanteLivros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            estanteLivros.Remove(livro);
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public Livro LivroFavorito
        {
            get { return this.livroFavorito; }
            set { this.livroFavorito = value; }
        }
        public List<Livro> EstanteLivros
        {
            get { return this.estanteLivros; }
            set { this.estanteLivros = value; }
        }
    }
}
