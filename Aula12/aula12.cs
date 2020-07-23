using System;
class aula12{

    static void Main(){
        int nota=50;
        string resultado="Reprovado";

       Console.Write ("Digite a nota do Aluno: ");
       nota=int.Parse(Console.ReadLine());

        if (nota >= 60){
            resultado="Aprovado";
            //Console.WriteLine ("Aprovado");
        }    
        Console.WriteLine("Resultado: {0}",resultado);
            //resultado=int.Parse(Console.ReadLine());
    }
}