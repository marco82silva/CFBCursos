using System;
class aula10{
    enum DiasSemana{Doming,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};

    static void Main(){
        
            DiasSemana ds = (DiasSemana)3;
            int ds2=(int)DiasSemana.Quarta;    
        
            Console.WriteLine (ds);
            Console.WriteLine (ds2);        
    }
}