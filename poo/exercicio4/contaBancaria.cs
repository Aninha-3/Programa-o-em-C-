namespace exercicio4;

class ContaBancaria()
{
    public int Numero;

    public string Titular;

    public double Saldo;

    public int deposito;

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
    /*
  public void Extrato()
    {
        string caminho = "extrato.txt"; // Caminho do arquivo a ser lido/escrito

        if (File.Exists(caminho))
        {
            string conteudo = File.ReadAllText(caminho); // Lê o conteúdo do arquivo

            string[] transacoes = conteudo.Split("\",\"");

            for (int cont = 0; cont < transacoes.Length; cont++)
            {
                Console.WriteLine(transacoes[cont]);
            }
        }
    }

*/


}