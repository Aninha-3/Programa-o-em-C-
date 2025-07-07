Console.Write("Dígite sua senha:");
string senha = Console.ReadLine();
string senhaCerta = "4N4C354";

while (senha != senhaCerta)
{
    Console.WriteLine("Senha incorreta, tente novamente!");
    Console.Write("Dígite sua senha:");
    senha = Console.ReadLine();
}



