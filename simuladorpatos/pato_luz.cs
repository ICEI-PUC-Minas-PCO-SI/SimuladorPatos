namespace simuladorpatos
{
    class pato_luz : pato, interface_pato_luz, Interface_pato_maluco
    {
        public pato_luz(string nome) : base(nome)
        {
        }

        public void Brilhar()
        {
            Console.WriteLine($"{Nome} tá brilhando!");
        }
        public void dancar()
        {
            Console.WriteLine($"Sou o {Nome}, o REI da dança");
        }
        public void latir()
        {
            Console.WriteLine($"Sei latir, mas não vou fazer isso, não sou louco!");
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
