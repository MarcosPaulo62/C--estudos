using static System.Console;

//::::::::: WHILE ::::::::://

// Boolean condicao = true;
// 
// while (condicao == true)
// {
//     WriteLine("Digite um valor, 0 para sair");
//     int valor = int.Parse(ReadLine());
// 
//     if (valor == 0)
//     {
//         WriteLine("Você saiu.");
//         condicao = false;
//     }
//     else
//         WriteLine("Você digitou "+ valor);
// }



//::::::::::::: DO :::::::::://

// Boolean condicao = true;
// 
// do {
//     WriteLine("Digite um valor, 0 para sair");
//     int valor = int.Parse(ReadLine());
// 
//     if (valor == 0)
//     {
//         WriteLine("Você saiu.");
//         condicao = false;
//     }
//     else
//         WriteLine("Você digitou "+ valor);
// } while (condicao == true);



//:::::::::: FOR :::::::::::://

// WriteLine("Digite um valor");
// int valor = int.Parse(ReadLine());
// 
// for (int i = valor; i <= 10; i++)
// {
//     WriteLine(i);
// }



//:::::::::: FOREACH :::::::::::://

int[] lista = {1, 2, 3, 4, 5, 6};

foreach(int numero in lista)
{
    WriteLine(numero);
}