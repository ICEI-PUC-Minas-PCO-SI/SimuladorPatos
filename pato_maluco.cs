namespace simuladorpatos
{
    class patomaluco : pato, Interface_pato_maluco, interface_pato_luz, Interface_pato_dev
    {
        public patomaluco(string nome) : base(nome)
        {
        }

        public void latir()
        {
            Console.WriteLine($"AU-AU");
        }

        public void dancar()
        {
            Console.WriteLine($"Prazer sou o {Nome}, e Pega esse gingado");
        }
        public void codando()
        {
            Console.WriteLine($"{Nome} está programando!");
        }

        public void Brilhar()
        {
            Console.WriteLine($"{Nome} tá brilhando!");
        }
        public void voar()
        {
            Console.WriteLine($"{Nome} sabe voar!");
        }

        public void grasnar()
        {
            Console.WriteLine($"{Nome} támbem sabe grasnar!");
        }
    }
}
