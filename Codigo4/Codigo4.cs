using System;

class Codigo4
{
  static void Main()
  {
    int [] num = new int[10];
    
    int i=9;

    while (i > 0)
      {
          num[i]=0;
          num[i]=i;
          Console.WriteLine(num[i]);
          i--; // decrementa o valor de i
      }
    Console.Write("\nFim do loop enquanto.");
    Console.ReadKey();
  }
}