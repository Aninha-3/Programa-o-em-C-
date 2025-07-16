namespace poo;

class Carro
{
    public string marca;
    public string modelo;
    public int ano;
    public bool ligado;



    public void Ligar()
    {
        if (!ligado)
        {
            ligado = true;
            Console.WriteLine("O carro está ligado");
        }
        else
        {
            Console.WriteLine("Carro já está ligado!");
        }
    }

    public void Desligar()
    {
        if (ligado)
        {
            ligado = false;
        }
        else
        {
            Console.WriteLine("Carro já está desligado!");
        }
    }

    public void Info()
    {
        Console.WriteLine($"A marca do carro é {marca}");
        Console.WriteLine($"O modelo do carro é {modelo}");
        Console.WriteLine($"O ano do carro é {ano}");

        if (ligado)
        {
            Console.WriteLine("O carro está ligado");
        }
        else
        {
            Console.WriteLine("O carro está desligado");
        }
    }
}