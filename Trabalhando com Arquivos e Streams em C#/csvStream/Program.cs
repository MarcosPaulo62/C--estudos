CriarCsv();

System.Console.WriteLine("\nPressione uma tecla para finalizar...");
Console.ReadKey();


static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                         "Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "Marcos",
            Email = "m@gmail.com",
            Telefone = 111111
        },
        new Pessoa()
        {
            Nome = "Antonio",
            Email = "a@gmail.com",
            Telefone = 222222
        },
        new Pessoa()
        {
            Nome = "José",
            Email = "j@gmail.com",
            Telefone = 333333
        }
    };

    var di = new DirectoryInfo(path);

    if (!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }

    using var sw = new StreamWriter(path);

    sw.WriteLine("nome,email,telefone");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone}";
        sw.WriteLine(linha);
    }
}


static void LerCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                         "Entrada", "usuarios-exportacao.csv");

    if(File.Exists(path))
    {
        using var sr = new StreamReader(path);

        var cabecalho = sr.ReadLine()?.Split(','); // paga os cabeçalhos separados por virguala e adiciona no array cabecalho

        while (true)
        {
            var registro = sr.ReadLine()?.Split(','); // vai pegando os registros
            if(registro == null)
                break;

            for (int i = 0; i < registro.Length; i++) // navega nos campos do registro
            {
                System.Console.WriteLine($"{cabecalho?[i]}: {registro[i]}"); // imprime o campo do cabeçalho e o campo do registro correspondente
            }

            System.Console.WriteLine("=================================");
        }
    }
    else
    {
        System.Console.WriteLine($"O arquivo {path} não existe");
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
}