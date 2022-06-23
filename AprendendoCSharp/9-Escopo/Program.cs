using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadeJoao = 26;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado)
            textoAdicional = "João está acompanhado";
        else
            textoAdicional = "João não está acompanhado";
        

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}