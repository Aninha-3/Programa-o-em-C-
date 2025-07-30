namespace exercicio4;

class ContaBancaria()
{
    public int Numero;

    public string Titular;

    public double Saldo;

    public int deposito;

    
    private List<string> historico = new List<string>();

    public void Info()
    {
        Console.WriteLine($"O número a sua conta é: {Numero}");
        Console.WriteLine($"O nome do titular é: {Titular}");
        Console.WriteLine($"O saldo é: {Saldo}");
    }

    public void ExibirSaldo()
    {
        if (Saldo > 0)
        {
            Console.WriteLine($"Este é o seu saldo : {Saldo}");
        }
        else
        {
            Console.WriteLine("Não é possovel ver saldo!");
        }
    }

    public void DepositarDinheiro( double deposito)
    {
        if(deposito > 0)
    {
        Saldo = Saldo + deposito;
    }
        else
        {
            Console.WriteLine("Valor para depósito inválido.");
        }

    }
    public void SacarDinheiro( double saque)
    {
        if(saque > 0)
    {
        Saldo = Saldo - saque;
    }
        else
        {
            Console.WriteLine("Valor para sacar é inválido.");
        }

    }

 

}