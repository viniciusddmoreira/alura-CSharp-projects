using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio: Múltiplos de 3"); ;

        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }
        

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}