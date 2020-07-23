using System;
class aula23{
    static void Main(){

        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2,5]{{11,22,33,44,55},{66,77,88,99,00}};

        Random random1=new Random();
        for(int i=0;i<vetor1.Length;i++){
                        
            vetor1[i]=random1.Next(50);
        }
        
        Console.WriteLine ("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch (array,valor;)
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("BinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado,pos);
        Console.WriteLine("--------------------------------------------------------");
        //public static void Copy(Array_Origem,Array_Destino,qtde_Elementos)

        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }    
        Console.WriteLine("--------------------------------------------------------");

        //public void CopyTo(Array_Destino,a_partir_desta_posição)

        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------------");

        //public long GetLength (dimensão)
        Console.WriteLine("GetLongLength");
        long qtde_ElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtde_ElementosVetor);
        Console.WriteLine("--------------------------------------------------------");

        //public int GetLowerBound(Dimensão)
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}",MenorIndiceVetor);
        Console.WriteLine("--------------------------------------------------------");

        //public int GetUpperBound(Dimensão)
        Console.WriteLine("GetUpperBound");
        int MaiorInidceVetor=vetor1.GetUpperBound(0);
        int MaiorInidceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}",MaiorInidceVetor);
        Console.WriteLine("--------------------------------------------------------");

        //public object GetValue(long indice)
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);
        Console.WriteLine("--------------------------------------------------------");

        //public static int IndexOf (Array,Valor)
        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Indice do primeiro valor 3:{0}",indice1);
        Console.WriteLine("--------------------------------------------------------");

        //public static int LastIndexOff (Array,Valor)
        Console.WriteLine("LastIndexOff");
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do ultimo valor 33:{0}",indice2);
        Console.WriteLine("--------------------------------------------------------");

        //public static void Reverse (Array)
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------------");
    
        //public void SetValue (Object valor,Long Pos)
        Console.WriteLine("SetValue");
        vetor2.SetValue(99,0);
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("Vetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------------");

        //public static void Sort(array)

        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }





    }
         

}