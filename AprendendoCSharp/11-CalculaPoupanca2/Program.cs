using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança 2");

        //Capital investido inicialmente
        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            // Considerando uma rentabilidade de 0.05% ao mês
            investimento *= 1.005;
            Console.WriteLine("No " + mes + "º mês você terá " + investimento + " reais investido.");
        }

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    } 
}