var path = @"C:\workspace\CSharp-estudos\Trabalhando com Arquivos e Streams em C#\Directory_And_DirectoryInfo\globo";

LerDiretorios(path);

LerArquivos(path);

System.Console.WriteLine("[enter] para finalizar");
System.Console.ReadKey();

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    // vai retornar um array com todos arquivos no caminho->path indicado

    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);

        System.Console.WriteLine($"[Nome]: {fileInfo.Name}");
        System.Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        System.Console.WriteLine($"[Último acesso]: {fileInfo.LastAccessTime}");
        System.Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");

        System.Console.WriteLine("===================================");
    }
}

static void LerDiretorios(string path)
{
    if(Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        
        // vai retornar um array com todos diretórios e subdiretórios no caminho->path indicado
    
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            System.Console.WriteLine($"[Nome]: {dirInfo.Name}"); // retorna nome do diretório
            System.Console.WriteLine($"[Raiz]: {dirInfo.Root}"); // retorna raiz do diretório
            if (dirInfo.Parent != null)
                System.Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}"); // retorna nome do pai do diretório
            
            System.Console.WriteLine("=====================================");
        }
    }    
    else
        System.Console.WriteLine($"{path} não existe");
}
