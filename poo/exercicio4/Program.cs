namespace exercicio4;

class Program
{
    static void Main(string[] args)
    {


        ContaBancaria conta = new ContaBancaria();

        conta.Numero = 9002036;
        conta.Titular = "Ana Clara";
        conta.Saldo = 40000;

        conta.Info();
        conta.ExibirSaldo();

        conta.DepositarDinheiro(52);
        conta.DepositarDinheiro(-10); // tentativa inválida
        conta.ExibirSaldo();
        
        conta.SacarDinheiro(30);
        conta.ExibirSaldo();
        conta.SacarDinheiro(50000); // tentativa inválida


        
        conta.Extrato();


    }
}
