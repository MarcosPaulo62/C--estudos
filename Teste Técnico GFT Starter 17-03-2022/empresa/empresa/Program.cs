using empresa.Models;

Funcionario funcionario = new("Marcos", 18, 3000);

Gerente gerente = new("Henrique", 35, 7000);

Supervisor supervisor = new("Júlio", 29, 5000);

Vendedor vendedor = new("Mário", 25, 3000);

Console.WriteLine(funcionario.ToString());
Console.WriteLine(gerente.ToString());
Console.WriteLine(supervisor.ToString());
Console.WriteLine(vendedor.ToString());
