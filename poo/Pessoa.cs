namespace poo;

class Pessoa
{
    //Definfinindo Atributo (campos) e o valor Ana
    public string nome = "Ana";
    public int idade;
    public string email;

    public void Falar()
    {
        Console.WriteLine($"A {nome} está falando");
    }

}