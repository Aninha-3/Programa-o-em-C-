Console.Write("Digite seu nome completo:");
string nomeUsuario = Console.ReadLine();

int nome = nomeUsuario.Trim().Length;
string sobrenome = "Silva";

Console.WriteLine(nome);

bool verificarNome = nomeUsuario.Contains("Silva");

string[] partesNome = nomeUsuario.Split(' ');
string firstNome = partesNome[0];
Console.WriteLine(firstNome);

