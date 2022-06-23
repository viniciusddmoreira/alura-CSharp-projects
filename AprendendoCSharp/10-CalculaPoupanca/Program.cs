using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        //Capital investido inicialmente
        double investimento = 1000;
        int mes = 1;

        while (mes <= 12 )
        {
            // Considerando uma rentabilidade de 0.05% ao mês
            investimento += investimento * 0.005;
            Console.WriteLine("No " + mes + "º mês você terá " + investimento + " reais investido.");
            mes++;

        }
        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}