using static System.Console;
using Colecoes.Helper;




// int[] arrayNum = new int[]{100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

// var min = arrayNum.Min();

// var max = arrayNum.Max();

// var med = arrayNum.Average();

// var soma = arrayNum.Sum();

// var arrayUnico = arrayNum.Distinct().ToArray();

// WriteLine($@"Mínimo: {min}
// Médio: {med}
// Máximo: {max}
// Soma: {soma}
// Array original: {string.Join(", ", arrayNum)}
// Array Distinto: {string.Join(", ", arrayUnico)}");




// int[] arrayNum = new int[]{ 4, 8, 100, 15, 0, 2};

// var min = arrayNum.Min();

// var max = arrayNum.Max();

// var med = arrayNum.Average();

// WriteLine($@"Mínimo: {min}
// Médio: {med}
// Máximo: {max}");




// int[] arrayNum = new int[]{1, 4, 8, 15, 2};

// var numParesQuery = 
//         from num in arrayNum
//         where num % 2 == 0
//         orderby num
//         select num;

// var numParesMetodo = arrayNum.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

// WriteLine($"Números pares Query: " + string.Join(", ", numParesQuery));

// WriteLine($"Números pares Método: " + string.Join(", ", numParesMetodo));




// Dictionary<string, string> estados = new Dictionary<string, string>(); 

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("SC", "Santa Catarina");
// estados.Add("RJ", "Rio de Janeiro");

// string valorProcurado = "SC";

// if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
//     WriteLine(estadoEncontrado);
// else
//     WriteLine($"Chave {valorProcurado} não encontrada no dicionário");

// WriteLine($"Removendo o valor {valorProcurado}");

// estados.Remove(valorProcurado);

// foreach (var item in estados)
// {
//     WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// WriteLine("Valor original:");
// WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "SC - Teste Atualização";

// WriteLine("Valor atualizado:");
// WriteLine(estados[valorProcurado]);

// foreach (var item in estados)
// {
//     WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }




// Stack<string> pilhaLivros = new Stack<string>();

// pilhaLivros.Push("Código Limpo");
// pilhaLivros.Push("1984");
// pilhaLivros.Push("Do Mil ao Milhão");

// WriteLine($"Livros na pilha {pilhaLivros.Count}");
// while (pilhaLivros.Count > 0)
// {
//     WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
//     WriteLine($"{pilhaLivros.Pop()} lido");
// }
// WriteLine($"Livros na pilha {pilhaLivros.Count}");




// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Marcos");
// fila.Enqueue("Paulo");
// fila.Enqueue("Giulia");
// fila.Enqueue("André");

// WriteLine($"Pessoas na fila {fila.Count}");
// while(fila.Count > 0)
// {
//     WriteLine($"Vez de: {fila.Peek()}");
//     WriteLine($"{fila.Dequeue()} atendido");
// }
// WriteLine($"Pessoas na fila {fila.Count}");




// OperacoesLista opLista = new OperacoesLista();

// List<string> estados = new List<string>{"SP", "MG", "BA"};

// WriteLine($"Quantidade de elementos na lista: {estados.Count}");

// opLista.ImprimeListaString(estados);

// WriteLine("");

// estados.Insert(1, "RJ");

// opLista.ImprimeListaString(estados);




// List<string> estados = new List<string>{"SP", "MG", "BA"};
// string[] estadosArray = new string[]{"RJ", "SC"};

// WriteLine($"Quantidade de elementos na lista: {estados.Count}");

// opLista.ImprimeListaString(estados);

// WriteLine("");

// estados.AddRange(estadosArray);

// opLista.ImprimeListaString(estados);




// List<string> estados = new List<string>{"SP", "MG", "BA"};

// WriteLine($"Quantidade de elementos na lista: {estados.Count}");

// opLista.ImprimeListaString(estados);

// WriteLine("Removendo o elemento");
// estados.Remove("MG");

// opLista.ImprimeListaString(estados);




// OperacoesArray op = new OperacoesArray();





// int[] array = new int[]{5, 7, 4, 6, 9};

// string[] arrayString = op.ConverterParaArrayString(array);




// int[] array = new int[]{5, 7, 4, 6, 9};

// WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2);

// WriteLine($"Capacidade array redimensionado: {array.Length}");




// int[] array = new int[]{5, 7, 4, 6, 9};

// int valor = 4;

// int indice = op.ObterIndice(array, valor);

// if (indice > -1)
//     WriteLine($"O índice do elemento {valor} é {indice}");
// else
//     WriteLine("O elemento não existe no array");




// int[] array = new int[]{5, 7, 4, 6, 9};

// int valor = 7;

// int valorAchado = op.ObterValor(array, valor);

// if (valorAchado > 0)
//     WriteLine("Encontrei o valor " + valorAchado);
// else
//     WriteLine("Não encontrei o valor");




// int[] array = new int[]{5, 7, 4, 6, 9};

// int valor = 3;

// bool todosMaiorQue = op.TodosMaiorQue(array, valor);

// if (todosMaiorQue)
//     WriteLine("Todos os valores são maiores que " + valor);
// else
//     WriteLine("Existem valores que não são maiores que " + valor);




// int[] array = new int[]{5, 3, 4, 1, 2};

// int valor = 5;

// bool existe = op.Existe(array, valor);

// if (existe)
//     WriteLine("Encontrei o valor {0}", valor);
// else
//     WriteLine("Não encontrei o valor " + valor);

// bool existeMaior = op.ExisteMaior(array, valor);

// if (existeMaior)
//     WriteLine("Encontrei um valor maior que {0}", valor);
// else
//     WriteLine("Não encontrei um valor maior que " + valor);




// int[] array = new int[]{5, 3, 4, 1, 2};
// int[] arrayCopia = new int[10];

// WriteLine("Array antes da cópia:");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);

// WriteLine("Array após a cópia:");
// op.ImprimirArray(arrayCopia);

// WriteLine("Array original:");
// op.ImprimirArray(array);

// // op.OrdenarBubbleSort(ref array);
// op.Ordenar(ref array);

// WriteLine("Array ordenado:");
// op.ImprimirArray(array);




// int[,] matriz = new int[4, 2]
// {
//     {1, 1},
//     {2, 2},
//     {3, 3},
//     {4, 4}
// };

// // matriz[0, 0] = 1;
// // matriz[0, 1] = 2;
// // matriz[0, 2] = 3;
// // matriz[0, 3] = 4;
// // matriz[1, 0] = 1;
// // matriz[1, 1] = 2;
// // matriz[1, 2] = 3;
// // matriz[1, 3] = 4;

// for (int i = 0; i < matriz.GetLength(0); i++) // 0 pra especificar linha
// {
//     for (int j = 0; j < matriz.GetLength(1); j++) // 1 pra especificar coluna
//     {
//         WriteLine(matriz[i, j]);
//     }
// }





// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 25;
// arrayInteiros[2] = int.Parse("32");

// WriteLine("Percorrendo o array pelo for");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     WriteLine(arrayInteiros[i]);
// }

// WriteLine("Percorrendo o array pelo foreach");
// foreach (int item in arrayInteiros)
// {
//     WriteLine(item);
// }
