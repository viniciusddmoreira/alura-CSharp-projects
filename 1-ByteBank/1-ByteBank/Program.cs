using _1_ByteBank;
using _1_ByteBank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank");

Console.WriteLine();

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular.nome = "Andre Bessa";
//conta1.conta = "10123-x";
//conta1.numeroAgencia = 23;
//conta1.nomeAgencia = "Agencia Central";
//conta1.saldo = 200;

//ContaCorrente conta2 = new(){
//    titular = "Amanda Nogueira",
//    conta = "10106-X",
//    numeroAgencia = 321,
//    nomeAgencia = "Agência Central",
//    saldo = 100
//};


//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numeroAgencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//Console.WriteLine();

//Console.WriteLine("Titular: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Número Agencia: " + conta2.numeroAgencia);
//Console.WriteLine("Nome da Agencia: " + conta2.nomeAgencia);
//Console.WriteLine("Saldo: " + conta2.saldo);

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Andre pré-transferência: " + conta1.saldo);
//conta1.Transferir(50, conta2);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Andre pós-transferência: " + conta1.saldo);
//conta1.Depositar(60);
//Console.WriteLine("Saldo do Andre pós-deposito: " + conta1.saldo);
//conta2.Sacar(10);
//Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);

//Cliente cliente = new()
//{
//    nome = "Vinícius Daniel",
//    cpf = "12345678",
//    profissao = "Programador C#"
//};

//ContaCorrente conta3 = new()
//{
//    titular = cliente,
//    conta = "232324-X",
//    numeroAgencia = 35,
//    nomeAgencia = "Agencia Central"
//};

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);


//Cliente sarah = new();
//sarah.Nome = "Sarah Silva";

//ContaCorrente conta4 = new(235, "12145-X");
//conta4.Saldo = 150;
//conta4.Titular = sarah;
//conta4.ExibirDadosDaConta();

//ContaCorrente conta5 = new(231, "231313-X");
//ContaCorrente conta6 = new(532, "121904-X");

//Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

//Cliente sarah = new();
//sarah.Nome = "Sarah Silva";
//sarah.Profissao = "Professora";
//sarah.Cpf = "11111111-12";

//Cliente ester = new();
//ester.Nome = "Ester Almeida";
//ester.Profissao = "Advogada";
//ester.Cpf = "868524125-32";

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new(159, "152869-x");
contaAndre.Titular = new();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);



Console.ReadKey();