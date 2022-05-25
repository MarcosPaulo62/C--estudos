using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

// LerCsvComDynamic();

// LerCsvComClasse();

// LerCsvComOutroDelimitador();

EscreverCsv();

System.Console.WriteLine("Pressione qualquer tecla para finalizar");
Console.ReadKey();

static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                        "Saida");

    var di = new DirectoryInfo(path);

    if (!di.Exists)
        di.Create();

    path = Path.Combine(path, "usuarios.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José",
            Email = "j@gmail.com",
            Telefone = 111111
        },
        new Pessoa()
        {
            Nome = "Antonio",
            Email = "a@gmail.com",
            Telefone = 212121
        },
        new Pessoa()
        {
            Nome = "Célia",
            Email = "c@gmail.com",
            Telefone = 332211
        }
    };

    using var sw = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = "|"
    };
    using var csvWriter = new CsvWriter(sw, csvConfig);
    csvWriter.WriteRecords(pessoas);
}

static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                        "Entrada", "Livros-preco-com-virgula.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    csvReader.Context.RegisterClassMap<LivroMap>();

    var registros = csvReader.GetRecords<Livro>().ToList();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"Titulo: {registro.Titulo}");
        System.Console.WriteLine($"Preco: {registro.Preco}");
        System.Console.WriteLine($"Autor: {registro.Autor}");
        System.Console.WriteLine($"Lancamento: {registro.Lancamento}");
        System.Console.WriteLine("===============================");
    }
}

static void LerCsvComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                        "Entrada", "usuarios-exportacao.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome: {registro.Nome}");
        System.Console.WriteLine($"email: {registro.Email}");
        System.Console.WriteLine($"telefone: {registro.Telefone}");
        System.Console.WriteLine("===============================");
    }
}

static void LerCsvComDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                        "Entrada", "Produtos.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome: {registro.Produto}");
        System.Console.WriteLine($"marca: {registro.Marca}");
        System.Console.WriteLine($"preço: {registro.Preco}");
        System.Console.WriteLine("===============================");
    }
}