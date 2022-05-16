using System;
class Program
{
    static void Main(String[] args)
    {
        //Desenvolver um algoritmo que leia quatro notas de um aluno,
        //calcular a média e imprimir.
        //[OPCIONAL]: A pontuação deste exercício será maior para quem imprimir se
        //o aluno for APROVADO ou REPROVADO;
        //[CRITÉRIO APROVAÇÃO]: Média > 7

        double nota=0,media;
        double[] notas = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Digite a {i+1} nota: ");
            notas[i] = double.Parse(s: Console.ReadLine());
            Console.WriteLine($"A {i+1} nota é {notas[i]}");
            nota += notas[i];
            Console.WriteLine(nota);
           
        }
        media = nota / 4;

        if (media >= 7)
        {
            Console.WriteLine($"Aluno aprovado com {media}");
        }
        else
        {
            Console.WriteLine($"Aluno reprovado com {media}");
        }
    }
}