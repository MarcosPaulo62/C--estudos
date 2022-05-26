using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using ExemploPOO.Helper;


FileHelper helper = new FileHelper();

var caminho = "C:\\TrabalhandoComArquivos";
var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
var listaStringCont = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

helper.DeletarArquivo(caminhoArquivoTesteCopia);
// helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
// helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
// helper.LerArquivo(caminhoArquivo);
// helper.LerArquivoStream(caminhoArquivo);
// helper.AdicionarTexto(caminhoArquivo, "Teste escrita");
// helper.AdicionarTextoStream(caminhoArquivo, listaStringCont);
// helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
// helper.CriarArquivoTexto(caminhoArquivo, "Olá! Esse é um teste de escrita de arquivo.");
// helper.ApagarDiretorio(caminhoPathCombine, true);
// helper.CriarDiretorio(caminhoPathCombine);
// helper.ListarArquivosDiretorios(caminho);
// helper.ListarDiretorios(caminho);









// ICalculadora calc = new Calculadora();
// System.Console.WriteLine(calc.Dividir(25, 5));






// Computador comp = new Computador();
// System.Console.WriteLine(comp.ToString());






// Corrente c = new Corrente();
// c.Creditar(100);
// c.Creditar(100);

// c.ExibirSaldo();






// Calculadora calc= new Calculadora();

// System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(20, 30));

// System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(20, 30, 50));






// Aluno a1 = new Aluno();
// a1.Nome = "Bruno";
// a1.Idade = 15;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "André";
// p1.Idade = 45;
// p1.Salario = 3000;
// p1.Apresentar();






// Valores válidos
// Retangulo r = new Retangulo();
// r.DefinirMedidas(30, 30);
// System.Console.WriteLine($"Área: {r.ObterArea()}");

// // Valores inválidos
// Retangulo r2 = new Retangulo();
// r2.DefinirMedidas(30, -30);
// System.Console.WriteLine($"Área: {r2.ObterArea()}");






// Pessoa p1 = new Pessoa();

// p1.Nome = "Steve";
// p1.Idade = 20;

// p1.Apresentar();