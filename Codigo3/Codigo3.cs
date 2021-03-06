using System;

class Codigo3
{
  static void Main()
  {
      int [] n = new int[5];

      for (int i = 0; i < n.Length; i++){n[i] = i;}

      for (int i = 0; i < n.Length; i++)
      {
         Console.WriteLine("O valor de num na posicao {0} é : {1}", i, n[i]);
      }
      Console.ReadKey();
  }
}