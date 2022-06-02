using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_GFT_08_02_2022.Models
{
    internal class Loja
    {
        protected string nome;
        protected string cnpj;
        protected List<Livro> livros;
        protected List<VideoGame> videoGames;

        public Loja()
        {
            nome = "";
            cnpj = "";
            livros = new List<Livro>();
            videoGames = new List<VideoGame>();
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public void listaLivros()
        {
            //lista todos os livros que uma loja tem, caso
            //a lista de livros seja vazia, mostrar 
            //no console "A loja não tem livros no seu estoque.
            if (livros.Count == 0)
                Console.WriteLine("A loja não tem livros no seu estoque.");
            else
            {
                Console.WriteLine($"A loja {nome} possui estes livros para venda:");
                foreach (var livro in livros)
                {
                    Console.WriteLine($"Título: {livro.Nome}, preço: {(livro.Preco).ToString("F1")}, quantidade: {livro.Qtd} em estoque.");
                }
            }

        }

        public void listaVideoGames()
        {
            //lista todos os vídeo games que uma loja tem,
            //caso a lista de vídeo games seja vazia,
            //mostrar no console "A loja não tem
            //video-games no seu estoque.".
            if (videoGames.Count == 0)
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            else
            {
                Console.WriteLine($"A loja {nome} possui estes video-games para venda:");
                foreach (var console in videoGames)
                {
                    Console.WriteLine($"Vídeo-game: {console.Modelo}, preço: {(console.Preco).ToString("F1")}, quantidade: {console.Qtd} em estoque.");
                }
            }
        }

        public void calculaPatrimonio()
        {
            //Soma os preços de todos produtos da loja e
            //retorna este valor como double
            double total = 0;
            foreach (var livro in livros)
            {
                total += livro.Preco * livro.Qtd;
            }
            foreach (var console in videoGames)
            {
                total += console.Preco * console.Qtd;
            }
            Console.WriteLine($"O patrimonio da loja: {nome} é de R$ {total.ToString("F1")}");
        }
    }
}
