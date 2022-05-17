using System;
class Ex6
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo que leia a altura de um homem e calcule o seu peso ideal,
        //utilize a seguinte fórmula: PESO IDEAL = (72.7 * H) – 58, onde H = altura.

        double altura, peso = 72.7, pesoIdeal;
        Console.WriteLine("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());

        pesoIdeal = (peso * altura) - 58;
        Console.WriteLine($"O peso ideal de uma pessoa de {altura}m é de: {pesoIdeal}Kg.");
    }
}