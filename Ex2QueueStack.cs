using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Queue f = new Queue();
    
    for(int i = 0; i < 5; i++){
      f.Enqueue(i+1);
    }
    
    Console.WriteLine("Fila tem " + f.Count + " elementos");
    
    Console.WriteLine(f.Dequeue() + " removido");
    
    if(f.Contains(1) == true){
      Console.WriteLine("sim");
    }
    else{
      Console.WriteLine("não");
    }
    if(f.Contains(5) == true){
      Console.WriteLine("sim");
    }
    else{
      Console.WriteLine("não");
    }
    
    Console.WriteLine("Próximo a ser removido: " + f.Peek());

    for(int i = 6; i <= 10; i++){
      f.Enqueue(i);
    }

    Console.WriteLine("Removidos ({0}) e ({1})", f.Dequeue(), f.Dequeue());

    f.Clear();
    Console.WriteLine(f.Count + " elementos restantes");
  }
}