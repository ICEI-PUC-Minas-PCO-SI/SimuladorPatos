using simuladorpatos;

class PatoDev : pato, Interface_pato_dev
{
    public PatoDev(string nome) : base(nome)
    {
    }

    public void codando()
    {
        Console.WriteLine($"{Nome} está programando!");
    }
}