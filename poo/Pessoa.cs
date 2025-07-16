namespace poo;

class Pessoa
{
    //Definfinindo Atributo (campos) e o valor Ana
    public string nome = "Ana";
    public int idade = 18;
    public string email = "ana@gmail";

    public void Falar()
    {
        Console.WriteLine($"A {nome} está falando");
    }
    public void Email()
    {
        Consoel.WriteLine($"A idade de {nome} é {idade}");
    }
}