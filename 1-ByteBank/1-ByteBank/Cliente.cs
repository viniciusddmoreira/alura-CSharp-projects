﻿namespace _1_ByteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public static int TotalClientesCadastrados { get; set; }
        public Cliente()
        {
            TotalClientesCadastrados++;
        }
    }
}
