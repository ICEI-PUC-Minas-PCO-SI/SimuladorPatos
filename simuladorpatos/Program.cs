namespace simuladorpatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pato_luz patoluz = new pato_luz("Patolino");

            patoluz.Brilhar();
            patoluz.bicar();
            patoluz.dancar();
            patoluz.latir();

            Console.WriteLine("--------------------------------------------");

            PatoDev patodev = new PatoDev("sr patinho");

            patodev.Nadar();
            patodev.codando();
            patodev.bicar();

            Console.WriteLine("--------------------------------------------");

            patomaluco patomalucao = new patomaluco("diogenes");

            patomalucao.dancar();
            patomalucao.latir();
            patomalucao.voar();
            patomalucao.bicar();
            patomalucao.codando();
            patomalucao.Brilhar();

            Console.WriteLine("--------------------------------------------");
        }
    }
}
