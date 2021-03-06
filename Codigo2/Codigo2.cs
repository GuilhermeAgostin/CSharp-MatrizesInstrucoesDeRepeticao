using System;

class Codigo2
{
  static void Main()
  {
    int[,]n= new int[2,3]; 
    int[,]n2= new int[2,2]{{10,20},{40,50}};

    n[0,0] = 15; n[0,1] = 25; n[0,2] = 45;
    n[1,0] = 12; n[1,1] = 68; n[1,2] = 79;

    Console.WriteLine(n[1,2]);
    Console.WriteLine(n2[1,1]);
    Console.ReadKey();
  }
}