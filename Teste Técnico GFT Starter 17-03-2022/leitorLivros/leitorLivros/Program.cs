using leitorLivros.Models;

Livro livro = new Livro();
livro.Titulo = "Código Limpo";
livro.QtdPaginas = 400;
livro.PaginasLidas = 200;
livro.adicionarPaginasLidas(50);

Leitor l1 = new Leitor("Marcos", livro);

Livro livro2 = new Livro(".NET POO", 150, 50);
Livro livro3 = new Livro(".NET Coleções", 100, 75);
Livro livro4 = new Livro("Scrum", 200, 15);

l1.AdicionarLivro(livro2);
l1.AdicionarLivro(livro3);
l1.AdicionarLivro(livro4);

l1.RemoverLivro(livro3);

Console.WriteLine($"Na estante de {l1.Nome} tem {(l1.EstanteLivros).Count} livros, são eles:");
foreach(var item in l1.EstanteLivros)
{
    Console.WriteLine($"Livro: {item.Titulo}, quantidade de páginas: {item.QtdPaginas}, páginas lidas: {item.PaginasLidas}, progresso: {item.verificarProgresso()}");
}