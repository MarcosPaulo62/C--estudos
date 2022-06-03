var numeros = Console.ReadLine().Split(" ");

int maior = 0, total = 0;

foreach (string n in numeros)
{
    int num = int.Parse(n);

    if (num > maior)
        maior = num;

    total += num;
}

Console.WriteLine($"O maior número é {maior}");
Console.WriteLine($"A soma dos valores é {total}");
