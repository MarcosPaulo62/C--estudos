using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Stack p = new Stack();
    
    for(int i = 1; i <= 5; i++){
      p.Push(i);
    }
    
    Console.WriteLine("Pilha tem " + p.Count + " elementos");
    
    Console.WriteLine(p.Pop() + " removido");
    
    if(p.Contains(1) == true){
      Console.WriteLine("sim");
    }
    else{
      Console.WriteLine("não");
    }
    if(p.Contains(5) == true){
      Console.WriteLine("sim");
    }
    else{
      Console.WriteLine("não");
    }
    
    Console.WriteLine("Próximo a ser removido: " + p.Peek());

    for(int i = 6; i <= 10; i++){
      p.Push(i);
    }

    Console.WriteLine("Removidos ({0}) e ({1})", p.Pop(), p.Pop());

    p.Clear();
    Console.WriteLine(p.Count + " elementos restantes");
  }
}