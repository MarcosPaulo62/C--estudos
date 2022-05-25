using static System.Console;

CriarDiretoriosGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,
                             "globo", "América do Sul",
                             "Argentina", "argentina.txt");

//MoverArquivo(origem, destino);

CopiarArquivo(origem, destino);


static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    }

    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta de destino");
        return;
    }

    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    }

    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta de destino");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 250MI");
        sw.WriteLine("IDH: 0,5");
        sw.WriteLine("Dados atualizados em: 23/05/2025");
    }
}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo"); // faz o caminho até o diretórioAtual/globo

    if(!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path); // Cria um diretório globo no diretório atual

        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul"); // Cria um subdiretório América do sul dentro do diretório globo
        var dirAsia = dirGlobo.CreateSubdirectory("Ásia");
        var dirAfrica = dirGlobo.CreateSubdirectory("África");

        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Paraguai");

        dirAsia.CreateSubdirectory("Japão");
        dirAsia.CreateSubdirectory("China");

        dirAfrica.CreateSubdirectory("Angola");
        dirAfrica.CreateSubdirectory("África do Sul");      
    }
    
}










