using _1_ByteBank.Titular;

namespace _1_ByteBank;

public class ContaCorrente
{
    public Cliente Titular { get; set; }
    private string _conta;
    public string Conta 
    {
        get 
        {
            return _conta;
        }
        set
        {
            if (value == null)
            {
                return;
            }
            else
            {
                _conta = value;
            }
            
        }
    }
    private int _numeroAgencia;
    public int NumeroAgencia 
    { 
        get 
        { 
            return _numeroAgencia; 
        }
        set
        {
            if (value <= 0)
            {
                return;
            }
            else
            {
                _numeroAgencia = value;

            }
        }
    }
    public string NomeAgencia { get; set; }

    private double _saldo;
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                _saldo = value;
            }
        }
    }

public bool Sacar(double valor)
    {
        if (_saldo < 0 || _saldo < valor )
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (_saldo < 0 || _saldo < valor)
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            destino._saldo += valor;
            return true;
        }
    }

    public void ExibirDadosDaConta()
    {
        Console.WriteLine("Nome: " + Titular.Nome);
        Console.WriteLine("CPF: " + Titular.Cpf);
        Console.WriteLine("Profissão: " + Titular.Profissao);
        Console.WriteLine("Conta: " + Conta);
        Console.WriteLine("Número Agencia: " + NumeroAgencia);
        Console.WriteLine("Nome da Agencia: " + NomeAgencia);
        Console.WriteLine("Saldo: " + Saldo);
    }

    public ContaCorrente (int numeroAgencia, string conta)
    {
        NumeroAgencia = numeroAgencia;
        Conta = conta;
        TotalDeContasCriadas++;
    }

    public static int TotalDeContasCriadas { get; set; }

}


