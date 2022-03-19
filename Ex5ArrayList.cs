using System;
using System.Collections;

class Aluno {
  public int matricula;
  public string nome;
  public string email;

  public Aluno(){
    this.nome = "";
    this.email = "";
    this.matricula = 0;
  }

  public Aluno(string nome, int matricula, string email){
    this.nome = nome;
    this.email = email;
    this.matricula = matricula;
  }
  public void Mostrar(){
    Console.WriteLine(nome + " (mat " + matricula + ") -- " + email);
  }
}

class Program {
  public static void Mostrar(ArrayList al){
    Console.WriteLine("Mostrar ArrayList: ");
   	foreach (object o in al){
      ((Aluno)o).Mostrar();
    }
  }

  public static void Mostrar(Object[] vetor){
    Console.WriteLine("Mostrar Object[]: ");
   	foreach (object o in vetor){
      ((Aluno)o).Mostrar();
    }
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();

    Console.WriteLine("================================== INSERÇÃO");
    for(int i = 0; i < 5; i++){
      int num = Math.Abs((new Random()).Next()) % 100;
      al.Add(new Aluno("Aluno " + num, num, "aluno" + num + "@aluno.com.br"));
    }

    Aluno a = new Aluno("João", 101, "joao@aluno.com.br");
   	al.Insert(2, a); // Adiciona o João na posição 2
    Mostrar(al);

    Console.WriteLine("================================== MOSTRAR ELEMENTOS");
    Console.WriteLine("ArrayList[0]: ");
    ((Aluno)al[0]).Mostrar();
    Console.WriteLine("ArrayList[1]: ");
    ((Aluno)al[1]).Mostrar();
    Console.WriteLine("ArrayList[2]: ");
    ((Aluno)al[2]).Mostrar();
    Console.WriteLine("ArrayList[3]: ");
    ((Aluno)al[3]).Mostrar();

    Console.WriteLine("================================== REMOÇÃO");
   	al.Remove(a); // Não ocorre exceção se elemento inexistente
   	al.RemoveAt(1); // Ocorre exceção de posição inexistente
   	al.RemoveRange(0, 2); // Remove 2 elementos à partir da posição 0. Ocorre exceção
    	                 		// se não existir a quantidade de elementos desejada
    Mostrar(al);

    Console.WriteLine("================================== CLEAR");
    al.Clear();
    Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);

    Console.WriteLine("================================== CONTAINS");
    for(int i = 0; i < 20; i++){
      al.Add(new Aluno("Aluno " + i, i, "aluno" + i + "@aluno.com.br"));
    }
    al.Add(a);
  
    if (al.Contains(a) == true){
      Console.WriteLine("Elemento " + a.nome + " encontrado!");
    } else {
      Console.WriteLine("Elemento " + a.nome + "  não encontrado!");
    }
    if (al.Contains(new Aluno("João", 101, "joao@aluno.com.br")) == true){
      Console.WriteLine("Elemento outro objeto encontrado!");
    } else {
      Console.WriteLine("Elemento outro objeto  não encontrado!");
    }

    Console.WriteLine("================================== INDEXOF");
    Console.WriteLine("{0} / {1} ", al.IndexOf(a), al.LastIndexOf(a));

    Console.WriteLine("================================== REVERSE");
    Mostrar(al);
    al.Reverse(); // Inverte os elementos de todo o ArrayList
    Mostrar(al);
    al.Reverse(3,5); // Inverte os 5 elementos à partir da posição 3
    Mostrar(al);

    Console.WriteLine("================================== TOARRAY");
    Object[] vetor = al.ToArray();
    Mostrar(vetor);

    Console.WriteLine("================================== TRIMTOSIZE");
    Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);
    al.TrimToSize();
    Console.WriteLine("Capacity({0}) / Count({1})", al.Capacity, al.Count);
  }
}