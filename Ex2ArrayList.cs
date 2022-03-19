using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    ArrayList al = new ArrayList();
    double media = 0;
    
    for(int i=0; i < 5; i++){
      int valor = int.Parse(Console.ReadLine());
      al.Add(valor);
      media += valor;
    }
    media /= 5;

    foreach(object o in al){
      if((int)o > media){
        Console.WriteLine(o);
      }
    }
  }
}