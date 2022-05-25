using System.Text;

var sb = new StringBuilder();

sb.AppendLine("Primeira linha do texto");
sb.AppendLine("Segunda linha");
sb.AppendLine("Última");

using var sr = new StringReader(sb.ToString());

var buffer = new char[10];
var tamanho = 0;

do
{
    System.Console.WriteLine(sr.ReadLine()); // vai ler uma linha do texto

} while (sr.Peek() >= 0); // sr.Peek retorna -1 quando não tiver mais linhas

// do
// {
//     buffer = new char[10]; // limpar o buffer
//     tamanho = sr.Read(buffer); // Passa os caracteres pro buffer e retorna a quantidade, no caso 10
//     System.Console.Write(string.Join("", buffer)); // Imprime os caracteres do buffer

// } while (tamanho >= buffer.Length);

System.Console.WriteLine("[enter] para finalizar...");
Console.ReadKey();