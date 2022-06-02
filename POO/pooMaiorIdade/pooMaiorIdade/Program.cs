using pooMaiorIdade.Entities;

Pessoa[] pessoas = new Pessoa[3];

for (int i = 0; i < pessoas.Length; i++)
{
    Console.WriteLine($"Nome da {i + 1}ª pessoa:");
    string nome = Console.ReadLine();

    Console.WriteLine($"Idade da {i + 1}ª pessoa:");
    int idade = int.Parse(Console.ReadLine());

    Pessoa pessoa = new(nome, idade);
    pessoas[i] = pessoa;
}

if (pessoas[0].Idade == pessoas[1].Idade && pessoas[1].Idade == pessoas[2].Idade)
    Console.WriteLine("Todas as pessoas têm a mesma idade.");
else
{
    int maiorIdade = 0;
    Pessoa maisIdade = new();
    foreach (Pessoa pessoa in pessoas)
    {
        if(pessoa.Idade > maiorIdade)
        {
            maiorIdade = pessoa.Idade;
            maisIdade.Nome = pessoa.Nome;
            maisIdade.Idade = pessoa.Idade;
        }
    }

    Console.WriteLine("\nA pessoa mais velha é:");
    maisIdade.ExibirDados();
}
