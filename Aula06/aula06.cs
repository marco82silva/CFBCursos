using System;
class aula06{
    static void Main(){
        double ValorCompra = 5.50;
        double ValorVenda;
        double lucro = 0.1;
        string produto = "Pastél";

        ValorVenda=ValorCompra+(ValorCompra*lucro);

        Console.WriteLine ("Produto.............:{0,15}",produto);
        Console.WriteLine ("Valor Compra........:{0,15:c}",ValorCompra);
        Console.WriteLine ("Lucro...............:{0,15:p}",lucro);
        Console.WriteLine ("Valor Venda.........:{0,15:c}",ValorVenda);
              
    }
    
}