using System;
class Program
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo para converter a temperatura
        //em graus Fahrenheit para Celsius,
        //a fórmula é C = (F -32) * 5 / 9;

        double c, f;
        Console.WriteLine("Digite a temperatura em Fº");
        f = double.Parse(Console.ReadLine());
        c = (f - 32) * (5 / 9);
        Console.WriteLine($"A temperatura de {f}f é {c}c");
    }
}
