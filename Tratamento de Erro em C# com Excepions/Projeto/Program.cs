using Projeto;

int a = 100, b = 0;

double resulatdo = 0;

try // captura a exceção
{
    if (b == 0)
        throw new MyClassException("Minha mensagem customizada de erro"); // lança uma exceção

    resulatdo = a / b;

    System.Console.WriteLine(resulatdo);
}
catch(DivideByZeroException ex) when (a < 1000) // trata exceçção divisão por zero, se a for menor que mil
{
    System.Console.WriteLine(ex.Message + " - 1°");
}
catch(Exception ex) // trata qualquer exceção
{
    System.Console.WriteLine(ex.Message + " - 2°");
}
finally // é impresso sempre
{
    System.Console.WriteLine("Divisão finalizada.");
}

