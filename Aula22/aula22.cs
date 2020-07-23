using System;
class aula05{

    static void Main(){
        int[] num=new int[5]{10,20,30,40,50};
    /*
        for(int i=0;i<num.Length;i++){
            Console.WriteLine(num[i]);
        }
    */
        foreach(int n in num){
            Console.WriteLine(n);
        }


    }
}