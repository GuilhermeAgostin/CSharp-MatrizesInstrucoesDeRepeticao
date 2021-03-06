using System;

class Codigo5
{
  static void Main()
  {
        string senha="123";
        string senhauser;
        int tentativa=0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a sua senha: \n");
            senhauser = Console.ReadLine();
            tentativa++;
          }
          while(senha != senhauser);
         
        Console.Clear();
        Console.WriteLine("Senha correta, após {0} tentativas.", tentativa);
        Console.ReadKey();
  }
}