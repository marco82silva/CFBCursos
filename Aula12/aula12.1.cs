using System;
class aula12{

    static void Main(){
        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0;
        string resultado="Reprovado";

       Console.Write ("Digite a PRIMEIRA NOTA: ");
       n1=int.Parse(Console.ReadLine());

       Console.Write ("Digite a SEGUNDA NOTA: ");
       n2=int.Parse(Console.ReadLine());

       Console.Write ("Digite a TERCEIRA NOTA: ");
       n3=int.Parse(Console.ReadLine());

       Console.Write ("Digite a QUARTA NOTA: ");
       n4=int.Parse(Console.ReadLine());
    
       res=n1+n2+n3+n4;
        
        if (res >= 60){
            
            resultado="Aprovado";
            //Console.WriteLine("Total: "+res);
        }    
        //Console.WriteLine("Total: "+res);
        Console.WriteLine("Total: {0}\nResultado: {1}",res,resultado);
            
    }
}