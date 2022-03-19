using System;
using System.Collections;

class Program {
  public static void Mostrar(ArrayList al){
    Console.Write("Mostrar ArrayList: ");
   	foreach (object o in al){
      Console.Write(o + " ");
    }
    Console.WriteLine();
  }

  public static void Mostrar(Object[] vetor){
    Console.Write("Mostrar Object[]: ");
   	foreach (object o in vetor){
      Console.Write(o + " ");
    }
    Console.WriteLine();
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();

    Console.WriteLine("================================== INSERÇÃO");
    al.Add(15);
   	al.Add(3.14159);
   	al.Add("AEDs");
   	al.Insert(2, 125); // Adiciona 125 na posição 2
    al.Add(1);
    al.Add(2);
    al.Add(3);
    al.Add(4);
    Mostrar(al);

    Console.WriteLine("================================== MOSTRAR ELEMENTOS");
    Console.WriteLine("ArrayList[0]: " + al[0]);
    Console.WriteLine("ArrayList[1]: " + al[1]);
    Console.WriteLine("ArrayList[2]: " + al[2]);
    Console.WriteLine("ArrayList[3]: " + al[3]);

    Console.WriteLine("================================== REMOÇÃO");
   	al.Remove(3.14159); // Não ocorre exceção se elemento inexistente
   	al.RemoveAt(1); // Ocorre exceção de posição inexistente
   	al.RemoveRange(0, 2); // Remove 2 elementos à partir da posição 0. Ocorre exceção
    	                 		// se não existir a quantidade de elementos desejada
    Mostrar(al);

    Console.WriteLine("================================== CLEAR");
    al.Clear();
    Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);

    Console.WriteLine("================================== CONTAINS");
    for(int i = 0; i < 20; i++){
      al.Add(i*2);
    }
    if (al.Contains(2) == true){
      Console.WriteLine("Elemento 2 encontrado!");
    } else {
      Console.WriteLine("Elemento 2 não encontrado!");
    }
    if (al.Contains(9) == true){
      Console.WriteLine("Elemento 9 encontrado!");
    } else {
      Console.WriteLine("Elemento 9 não encontrado!");
    }

    Console.WriteLine("================================== INDEXOF");
    al.Add(2);
    Console.WriteLine("IndexOf(2): " + al.IndexOf(2));
    Console.WriteLine("LastIndexOf(2): " + al.LastIndexOf(2));

    Console.WriteLine("================================== REVERSE");
    Mostrar(al);
    al.Reverse(); // Inverte os elementos de todo o ArrayList
    Mostrar(al);
    al.Reverse(3,5); // Inverte os 5 elementos à partir da posição 3
    Mostrar(al);

    Console.WriteLine("================================== SORT");
    al.Sort();
    Mostrar(al);

    Console.WriteLine("================================== TOARRAY");
    Object[] vetor = al.ToArray();
    Mostrar(vetor);

    Console.WriteLine("================================== TRIMTOSIZE");
    Console.Write("Capacity({0}) / Count({1})\n", al.Capacity, al.Count);
    al.TrimToSize();
    Console.Write("Capacity({0}) / Count({1})\n", al.Capacity, al.Count);

    Console.WriteLine("================================== BINARYSEARCH");
    int posicao = al.BinarySearch(2);
    Console.WriteLine("Posicao do [2]: " + posicao);
    posicao = al.BinarySearch(9);
    Console.WriteLine("Posicao do [9]: " + posicao);
  }
}