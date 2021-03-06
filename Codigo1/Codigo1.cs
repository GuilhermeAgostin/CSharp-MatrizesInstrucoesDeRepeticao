using System;

class Codigo1 
{
    static void Main()
    {
        int[] n = new int[5];
        int[] n1 = new int[3]{15,20,30};
        int[] n2 = {45,75,99,100};

        n[0]=1;
        n[1]=2;
        n[2]=3;
        n[3]=4;
        n[4]=5;

        Console.WriteLine(n[4]);
        Console.WriteLine(n1[1]);
        Console.WriteLine(n2[3]);
        Console.ReadKey();
    }
}