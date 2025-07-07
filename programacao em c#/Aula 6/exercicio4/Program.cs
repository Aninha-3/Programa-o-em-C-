Console.Write("Digite uma frase:");
string fraseUsuario = Console.ReadLine();

bool ComecaComOla = fraseUsuario.StartsWith("Olá");
Console.WriteLine(ComecaComOla);

bool TerminaComOla = fraseUsuario.EndsWith("!");
Console.WriteLine(TerminaComOla);

// Achar a palavra 
int posicao = fraseUsuario.IndexOf("Olá");
if (posicao != -1)
{
    Console.WriteLine($"A frase tem o Olá");
}
else
{
    Console.WriteLine($"A frase não tem o Olá ");
}