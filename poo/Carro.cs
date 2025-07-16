namespace poo;

class carro
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
        }
        else
        {
            Console.WriteLine("Carro já está ligado!");
       }
    }

}