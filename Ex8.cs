using System;
class Program
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo que leia dois valores, A e B,
        //utilizar operador aritmético de subtração e imprimir o total;
        //[OPCIONAL]: Se o valor for negativo,
        //imprimir TOTAL NEGATIVO senão TOTAL POSITIVO;

        double a, b, result;
        Console.WriteLine("Digite o primeiro numero: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        b = double.Parse(Console.ReadLine());
        result = a - b;
        Console.WriteLine($"A subtração de {a} - {b} = {result}");
        if (result < 0)
        {
            Console.WriteLine("TOTAL NEGATIVO");
        }
        else
        {
            Console.WriteLine("TOTAL POSITIVO");
        }

    }
}