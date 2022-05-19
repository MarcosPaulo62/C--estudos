using System;

class SomaDoisNumeros {
	public static void Main() {
		//Declaracao de variáveis
		int num1, num2, soma;
		
		//Leitura do primeiro numero
		Console.Write ("Digite um número: ");
		num1 = int.Parse (Console.ReadLine());
		
		//Leitura do segundo numero
		Console.Write ("Digite um número: ");
		num2 = int.Parse (Console.ReadLine());

		//Somar os dois numeros
		soma = num1 + num2;

		//Imprimir na tela o resultado da soma
		Console.WriteLine ("Soma: " + soma);
		}
}