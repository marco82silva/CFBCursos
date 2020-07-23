using System;
class aula17{

    static void Main(){
        //int n1,n2,n3,n4,n5
        int[] n=new int[5]; //0-4
        int[] num=new int [3]{55,77,99};
        //int[] num={55,77,99,66,88};
        string[] veiculos=new string[3];

        veiculos[0]="Carro";
        veiculos[1]="Avião";
        veiculos[2]="Navio";

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(num[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(num[2]);
        
        Console.WriteLine(n[0]);
        Console.WriteLine(n[1]);
        Console.WriteLine(n[2]);
        Console.WriteLine(n[3]);
        Console.WriteLine(n[4]);

        Console.WriteLine(veiculos[0]);
        Console.WriteLine(veiculos[1]);
        Console.WriteLine(veiculos[2]);
    }
}