namespace poo;

class Program
{
    static void Main(string[] args) //
    {
        Pessoa ana = new Pessoa(); //Instanciar uma novo objeto
        Pessoa kaio = new Pessoa();

        kaio.nome = "Kaio";

        // Invocar o método
        ana.Falar();


        Carro bumblebee = new Carro();
        bumblebee.marca = "Chevrolet";
        bumblebee.modelo = "Camaro";
        bumblebee.ano = 2010;
        bumblebee.Ligar();

    }
}
