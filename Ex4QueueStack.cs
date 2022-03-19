using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Queue f = new Queue();

    for(int i = 0; i < 10; i++){
      Console.WriteLine("Digite um caractere (" + (i+1) + "/10): ");
      char car = Console.ReadLine()[0];
      
      if(car >= 'A' && car <='Z'){
        Console.WriteLine("Inserindo o caractere na fila!");
        f.Enqueue(car);
      }
      else if(car >= 'a' && car <= 'z'){
        Console.WriteLine("Retirando " + f.Dequeue());
      }
      else{
        Console.WriteLine("Próximo a ser removido: " + f.Peek());
      }
      
      
    }
  }
}