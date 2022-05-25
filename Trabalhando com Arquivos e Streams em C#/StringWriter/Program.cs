string textReaderText = "Cristiano Ronaldo dos Santos Aveiro é " +
                        "um futebolista português que atua como " +
                        "extremo-esquerdo ou ponta de lança.\n" +

                        "Atualmente joga pelo Manchester United e " +
                        "pela Seleção Portuguesa. É o jogador com " +
                        "mais golos na história do futebol em jogos " +
                        "oficiais.\n\n";

System.Console.WriteLine($"Texto original: {textReaderText}");

string linha, paragrafo = null;

var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();
    if (linha != null)
        paragrafo += linha + " ";
    else
    {
        paragrafo += "\n";
        break;
    }
}

System.Console.WriteLine($"Texto modificado: {paragrafo}");
int caractereLido;
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.Read(); // recebe um decimal referente ao caractere
    if(caractereLido == -1) // quando acabar os caracteres é retornado -1
        break;

    caractereConvertido = Convert.ToChar(caractereLido); // converte o decimal em caractere

    if(caractereConvertido == '.')
    {
        sw.Write("\n\n");
    }
    else 
    {
        sw.Write(caractereConvertido);
    }
}

System.Console.WriteLine($"Texto armazenado no StreamWriter: {sw.ToString()}\n\n");
System.Console.WriteLine("Pressione [enter] para sair");
Console.ReadKey();
