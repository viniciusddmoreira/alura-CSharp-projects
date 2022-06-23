using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversoes e outros tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);

        //o int é um tipo de variável que suporta valores de até 32 bits
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // long é  um tipo de variável que suporta valores de até 64 bits
        long x = 2000000000000;
        Console.WriteLine(x);

        //long é um tipo de variável que suporta valores de até 16 bits
        short y = 15000;
        Console.WriteLine(y);

        float altura = 16.2f;
        Console.WriteLine(altura);

        int trinta = 10 + 20;
        Console.WriteLine("A idade de Marcos é" + trinta);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}