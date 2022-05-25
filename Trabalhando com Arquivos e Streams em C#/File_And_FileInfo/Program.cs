using static System.Console;

WriteLine("Digite o nome do arquivo:");

var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite Enter para finalizar...");
ReadKey();



static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars()) // rodando array de caracteres inválidos
    {
        nome = nome.Replace(@char, '-'); // substituindo caracteres inválidos por "-"
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);

        sw.WriteLine("Linha 1 do arquivo");
        sw.WriteLine("Linha 2 do arquivo");
        sw.WriteLine("Linha 3 do arquivo");
        sw.WriteLine("Linha 4 do arquivo");
        sw.WriteLine("Linha 5 do arquivo");
    }
    catch (System.Exception)
    {
       WriteLine("Nome de arquivo inválido!");
    }
    
}











