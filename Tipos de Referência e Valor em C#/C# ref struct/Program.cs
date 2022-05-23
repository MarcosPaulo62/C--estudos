using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Marcos";
p1.Idade = 18;
p1.EnderecoPessoa = new Endereco()
{
    Cidade = "Cruz das Almas",
    CEP = "44380000",
    Numero = 01,
    Logradouro = "Araçá"
};

WriteLine("fim");