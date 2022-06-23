using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 27;
        int quantidadePessoas = 2;

        if (idadeJoao < 18)
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }
        else
        {
            Console.WriteLine("Pode entrar");
        }

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}