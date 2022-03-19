using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Queue f = new Queue();
    f.Enqueue(1);
    f.Enqueue(2);
    f.Enqueue(3);
    Console.Write("Fila: ({0}) / ({1}) / ({2})\n", f.Contains(1), f.Count, f.Peek());
    Console.WriteLine(f.Dequeue());
    Console.Write("Fila:({0}) / ({1}) / ({2})\n", f.Contains(1), f.Count, f.Peek());

    Stack p = new Stack();
    p.Push(1);
    p.Push(2);
    p.Push(3);
    Console.Write("Pilha: ({0}) / ({1}) / ({2})\n", p.Contains(1), p.Count, p.Peek());
    Console.WriteLine(p.Pop());
    Console.Write("Pilha:({0}) / ({1}) / ({2})\n", p.Contains(1), p.Count, p.Peek());
  }
}