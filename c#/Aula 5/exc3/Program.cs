Console.WriteLine("Dígite um número para ver a tabuada:");

int n = int.Parse(Console.ReadLine());

Console.WriteLine($"A tabuada do {n} é:");

for (int i = 1; i <= 10; i++)
{
    int resultado = n * i;
    Console.WriteLine($"{n} x {i} = {resultado}");
}


