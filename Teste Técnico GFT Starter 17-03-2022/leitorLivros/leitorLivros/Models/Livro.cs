using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leitorLivros.Models
{
    internal class Livro
    {
        protected string titulo;
        protected int qtdPaginas;
        protected int paginasLidas;

        public Livro()
        {
        }

        public Livro(string titulo, int qtdPaginas, int paginasLidas)
        {
            this.titulo = titulo;
            this.qtdPaginas = qtdPaginas;
            this.paginasLidas = paginasLidas;
        }

        public double verificarProgresso()
        {
            double porcentagem = (paginasLidas * 100) / qtdPaginas;
            return Math.Floor(porcentagem);
        }

        public void adicionarPaginasLidas(int pags)
        {
            this.paginasLidas += pags;
        }

        public string Titulo
        {
            get { return titulo; }  
            set { titulo = value; }
        }
        public int QtdPaginas
        {
            get { return qtdPaginas; }
            set { qtdPaginas = value; }
        }
        public int PaginasLidas
        {
            get { return paginasLidas; }
            set{ paginasLidas = value; }
        }
    }
}
