using System;
using System.Collections;

class Program {
  public static void Mostrar(ArrayList al){
    Console.WriteLine("Mostrar ArrayList: ");;
   	foreach (object o in al){
      Console.WriteLine(o);
    }
  }

  public static void Mostrar(Object[] vetor){
    Console.WriteLine("Mostrar Object[]: ");
   	foreach (object o in vetor){
      Console.WriteLine(o);
    }
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();
    string palavra = "";

    Console.WriteLine("================================== INSERÇÃO");
    for(int i = 0; i < 5; i++){
      int num = Math.Abs((new Random()).Next()) % 100;
      palavra = ("Palavra " + num);
      al.Add(palavra);
    }
    al.Insert(5, "João");
    
    Mostrar(al);

    Console.WriteLine("================================== MOSTRAR ELEMENTOS");
    Console.WriteLine("ArrayList[0]: " + al[0]);
    Console.WriteLine("ArrayList[1]: " + al[1]);
    Console.WriteLine("ArrayList[2]: " + al[2]);
    Console.WriteLine("ArrayList[3]: " + al[3]);

    Console.WriteLine("================================== REMOÇÃO");
   	al.Remove("João"); // Não ocorre exceção se elemento inexistente
   	al.RemoveAt(1); // Ocorre exceção de posição inexistente
   	al.RemoveRange(0, 2); // Remove 2 elementos à partir da posição 0. Ocorre exceção
    	                 		// se não existir a quantidade de elementos desejada
    Mostrar(al);

    Console.WriteLine("================================== CLEAR");
    al.Clear();
    Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);

    Console.WriteLine("================================== CONTAINS");
    for(int i = 0; i < 20; i++){
      int num = Math.Abs((new Random()).Next()) % 100;
      palavra = ("Palavra " + num);
      al.Add(palavra);
    }
    al.Insert(5, "João");

    if (al.Contains("João") == true){
      Console.WriteLine("Elemento João encontrado!");
    } else {
      Console.WriteLine("Elemento João não encontrado!");
    }
    if (al.Contains("José") == true){
      Console.WriteLine("Elemento José encontrado!");
    } else {
      Console.WriteLine("Elemento José não encontrado!");
    }

    Console.WriteLine("================================== INDEXOF");
    al.Add("João");
    Console.WriteLine("IndexOf(João): " + al.IndexOf("João"));
    Console.WriteLine("LastIndexOf(João): " + al.LastIndexOf("João"));

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
    int posicao = al.BinarySearch("João");
    Console.WriteLine("Posicao do [João]: " + posicao);
    posicao = al.BinarySearch("José");
    Console.WriteLine("Posicao do [José]: " + posicao);
  }
}