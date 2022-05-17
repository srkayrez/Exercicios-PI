using System;
class Ex9
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo que leia dois valores,
        //A e B, utilizar operador aritmético de divisão e modularização,
        //ou seja, imprimir apenas o resto da divisão;
        //[OPCIONAL]: Tratar divisão por 0
        double a, b, div, mod;
        Console.WriteLine("Digite o primeiro numero: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        b = double.Parse(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("O segundo valor da divisao nao pode ser 0!");
        }
        else
        {
            div = a / b;
            mod = a % b;
            Console.WriteLine($"A divisao de {a} / {b} = {div}.");
            Console.WriteLine($"O resto da divisao de {a % b} = {mod}");
        }
    }
}