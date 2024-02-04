// See https://aka.ms/new-console-template for more information
using System;

class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do produto:");
        string nomeProduto = Console.ReadLine();

        Console.WriteLine("Digite o preço unitário do produto:");
        decimal precoUnitario = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a quantidade comprada:");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        decimal valorTotal= CalcularValorComDesconto(precoUnitario, quantidade);
        Console.WriteLine($"O produto {nomeProduto} tem o valor total a ser pago: R$ {valorTotal:N2}");        
    }

    static decimal CalcularValorComDesconto(decimal precoUnitario, int quantidade)
    {
        decimal valorTotal;
        
        if (quantidade <= 10)
        {
            valorTotal = precoUnitario * quantidade;
            
        }
        else if (quantidade <= 20)
        {
            valorTotal = precoUnitario * quantidade;
            valorTotal -= valorTotal * 0.10m; ; // 10% desconto
        }
        else if (quantidade <= 50)
        {
            valorTotal = precoUnitario * quantidade;
            valorTotal -= valorTotal * 0.20m;  // 20% de desconto
         
        }
        else
        {
            valorTotal = precoUnitario * quantidade;
            valorTotal -= valorTotal * 0.25m;  // 25% de desconto
        }

        return valorTotal;
    }
}
