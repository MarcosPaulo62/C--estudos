using static System.Console;
public class Program
{
    static void Demo6()
    {
        int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if (idxEncontrado >= 0)
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        else
            WriteLine("O número digitado não foi encontrado.");
    }
    static void Demo5()
    {
        var pares = new int[]{0, 2, 4, 6, 8};

        MudarParaImpar(pares);

        WriteLine($"Os ímpares {string.Join(", ", pares)}");
    }
    static void Demo4()
    {
        string nome = "Paulo";

        AlterarNome(nome, "Marcos");

        WriteLine($"Novo nome é: {nome}");
    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa
        {
            Nome = "Paulo",
            Idade = 18,
            Documento = "2211"
        };

        var p2 = p1;

        p1 = AlterarNome(p1, "Marcos");

        WriteLine($@"
        Nome de p1 é: {p1.Nome}
        Nome de p2 é: {p2.Nome}
        "); 
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Paulo";
        p1.Idade = 18;
        p1.Documento = "2211";

        Pessoa p2 = p1.Clone();

        AlterarNome(p1, "Marcos");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        "); 
    }
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável a é: {a}");
    }
    
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    
    static void AlterarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    
    static StructPessoa AlterarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }
    
    static void AlterarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] += 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int n)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == n)
            {
                return i;
            }
        }
        return -1;
    }
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa p)
    {
        foreach (var item in pessoas)
        {
            if (item.Nome == p.Nome)
                return true;
        }
        return false;
    }
    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa p)
    {
        foreach (var item in pessoas)
        {
            if (item.Equals(p))
                return true;
        }
        return false;
    }
    public static void Main()
    {
        List<StructPessoa> pessoas = new List<StructPessoa>()
        {
            new StructPessoa(){Nome = "Marcos"},
            new StructPessoa(){Nome = "Paulo"},
            new StructPessoa(){Nome = "Silva"},
            new StructPessoa(){Nome = "Costa"},
            new StructPessoa(){Nome = "Antonio"}
        };

        WriteLine("Digite a pessoa que gostaria de encontrar:");
        var nome = ReadLine();
        var pessoa = new StructPessoa(){Nome = nome};

        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if(encontrado)
            WriteLine("Pessoa localizada!");
        else
            WriteLine("Pessoa não localizada");
    }
}