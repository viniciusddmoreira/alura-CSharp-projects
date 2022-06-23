using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a Longo Prazo");

        //Capital investido inicialmente
        double investimento = 1000;
        // Rentabilidade de 0.05% ao mês inicialmente
        double fatorRendimento = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }
        Console.WriteLine("Depois de 5 anos você terá R$: " + investimento);

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}