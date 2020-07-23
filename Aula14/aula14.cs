using System;
class aula14{

    static void Main(){
        int n1,n2,n3,n4,res;
        n1=n2=n3=n4=res=0;
        string resultado;

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
            if(res >=90){
                resultado="Aprovado com Louvor";    
            }else{
                resultado="Aprovado";
            }
                        
        }else 
            if(res>=40){
            resultado="Recuperação";
        
        }else{
            resultado = "Reprovado";
        }    
      Console.WriteLine("Total: {0}\nResultado: {1}",res,resultado);
            
    }
}