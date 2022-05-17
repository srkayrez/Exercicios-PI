using System;
class Ex2
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo que leia a cotação do euro converta para o Real,
        //calcule a compra de 750 euros e imprima o resultado;

        double euroHoje, euros, valorFinal ;
        Console.WriteLine("Digite o valor do euro hoje: ");
        euroHoje = double.Parse(Console.ReadLine());
        Console.WriteLine($"O euro esta custando: R${euroHoje} hoje.");
        Console.WriteLine("Digite a quantia em euros: ");
        euros = double.Parse(Console.ReadLine());
        valorFinal = euroHoje * euros;
       
        Console.WriteLine($"O valor de {euros} euros é {valorFinal} reais");


    }
}