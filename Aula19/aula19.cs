using System;
class aula19{

    static void Main(){
    
    int[] num=new int[10];
    
    //    for (int num=0; num<10; num++){
    //        Console.WriteLine ("Valor de num: {0}",num);
      
        for (int i=0; i<num.Length; i++){
            num[i]=i;
        }
        for (int i=0; i<num.Length; i++){
            Console.WriteLine("Valor de num na pos{0}: {1}",i,num[i]);
        }

        }
   // }
}