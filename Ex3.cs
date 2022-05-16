using System;
class Program
{
    static void Main(string[] args)
    {
        //Desenvolver um algoritmo de comissão de vendas,
        //um vendedor de carro vendeu 500 mil no mês de Maio,
        //sabendo que a comissão dele é de 5% ao mês,
        //qual será o valor que este vendedor receberá de comissão,
        //calcule e imprima;

        double totalVendas = 500000.0, totalComissao;
        double comissao = 0.05;
        totalComissao = totalVendas * comissao;
        
        Console.WriteLine($"O vendedor vendeu: R${totalVendas} no mes de maio.");
        Console.WriteLine($"Sua comissão sera de {totalComissao}");
    }
}