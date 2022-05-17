using System;
class Ex4
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo para converter a temperatura em graus Celsius para Fahrenheit,
        //a fórmula é F = (9 * C + 160) / 5;

        double c, f;
        Console.WriteLine("Digite o valor da temperatura em Cº");
        c = double.Parse(Console.ReadLine());
        f = (9 * c + 160) / 5;
        Console.WriteLine($"A temperatura de {c}c é: {f}f");
    }
}