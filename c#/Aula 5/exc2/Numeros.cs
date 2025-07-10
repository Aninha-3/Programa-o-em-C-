int num;

Console.WriteLine("Digite um número inteiro e posiivo:");

while (!int.TryParse(Console.ReadLine(), out num) || num <= 0) ;
{
    Console.WriteLine("Apenas números inteiros!");
}
int soma = 0;

for (int i = 1; i <= num; i++)
{
    soma += i;
}
Console.WriteLine($"A soma dos valores de 1 té {num} è {soma}.");




