namespace simuladorpatos
{
    class pato
    {
        public string Nome { get; set; }
        public pato(string nome)
        {
            Nome = nome;
        }

        public void Nadar()
        {
            Console.WriteLine($"{Nome} está nadando");
        }
        public void bicar()
        {
            Console.WriteLine($"{Nome} te bicou");
        }


    }
}
