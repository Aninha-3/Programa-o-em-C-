// Cadastro do usuário
Console.Write("Digite o seu nome, email e numero de telefone separados por virgulas:");
string informacoes = Console.ReadLine();
Console.WriteLine(informacoes);

string[] cadastro = informacoes.Split(',');


if (cadastro.Length == 3)
{
    string nome = cadastro[0].Trim();
    string email = cadastro[1].Trim();
    string numero = cadastro[2].Trim();

    // Impressão dos dados 
    Console.WriteLine("Cadastro realizado com sucesso!");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Email: {email}");
    Console.WriteLine($"Numero: {numero}");
}

