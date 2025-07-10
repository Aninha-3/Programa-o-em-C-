double valor;

do
{
    Console.Write("Dígite um valor:");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    {
        double resultado = valor * 0.25;
        Console.WriteLine($"25% de  {valor} é  {resultado}");
    }
}
while (valor != 0); {
    Console.WriteLine("Programa encerrado!");
 }