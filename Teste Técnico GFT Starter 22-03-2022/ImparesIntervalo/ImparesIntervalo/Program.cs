/*Elabore um algoritmo para mostrar os números ímpares existentes em um intervalo. 
O usuário deverá fornecer os valores inicial (inicial > 0) e final(inicial<final) e os 
números ímpares existentes no intervalo ([inicial, final]) devem ser separados por um
espaço em branco.*/

string numeros = Console.ReadLine();

string[] intervalo = numeros.Split(' ');

int inicio = int.Parse(intervalo[0]);
int fim = int.Parse(intervalo[1]);

if (fim > inicio)
{
    for (int i = inicio; i < (fim + 1); i++)
    {
        if(i % 2 != 0)
            Console.Write(i + " ");
    }
}    
else
    Console.WriteLine("Digite valores válidos");
