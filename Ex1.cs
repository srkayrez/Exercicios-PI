using System;
class Programa
{
    static void Main(string[] args)
    {
        //Desenvolva um algoritmo que calcule a idade média dos alunos de uma classe da faculdade,
        //sabendo que o aluno mais novo tem 20 anos e o mais velho tem 50 anos,
        //utilize a seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2;

        int idadeMedia, idadeMinima = 20, idadeMaxima = 50;
        idadeMedia = (idadeMinima + idadeMaxima) / 2;
        Console.WriteLine($"A menor idade é de: {idadeMinima}");
        Console.WriteLine($"A maior idade é de: {idadeMaxima}");
        Console.WriteLine($"A idade media é de: {idadeMedia}");
    }
}