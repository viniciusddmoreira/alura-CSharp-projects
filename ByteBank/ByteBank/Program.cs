using ByteBank;
using ByteBank.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario vinicius = new Funcionario();
vinicius.Nome = "Vinicius";
vinicius.CPF = "123.456.789-00";
vinicius.Salario = 3000;



Console.WriteLine(vinicius.Nome);
Console.WriteLine(vinicius.Salario);

Diretor roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.CPF = "555.444.666-22";
roberta.Salario = 7000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.Salario);

gerenciador.Registrar(vinicius);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações:" + gerenciador.GetTotalBonificacao());



