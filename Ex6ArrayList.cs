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


class CompareAluno : IComparer {
  public int Compare(Object o1, Object o2) {
    return ((Aluno)o1).nome.CompareTo(((Aluno)o2).nome);
  }
}

class Program {
  public static void Mostrar(ArrayList al){
    Console.WriteLine("Mostrar ArrayList: ");;
   	foreach (object o in al){
      ((Aluno)o).Mostrar();
    }
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();

    Console.WriteLine("================================== INSERÇÃO");
    for(int i = 0; i < 20; i++){
      int num = Math.Abs((new Random()).Next()) % 100;
      al.Add(new Aluno("Aluno " + num, num, "aluno" + num + "@aluno.com.br"));
    }
    Mostrar(al);

    Console.WriteLine("================================== SORT");
    al.Sort(new CompareAluno());
    Mostrar(al);

    Console.WriteLine("================================== BINARYSEARCH");
    Aluno a = (Aluno)al[Math.Abs((new Random()).Next()) % al.Count];
    int posicao = al.BinarySearch(a, new CompareAluno());
    Console.WriteLine("Posicao de (" + a.nome + "): " + posicao);
    a.nome = "José";
    posicao = al.BinarySearch(a, new CompareAluno());
    Console.WriteLine("Posicao de (" + a.nome + "): " + posicao);
  }
}