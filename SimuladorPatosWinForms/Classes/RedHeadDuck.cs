using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class RedHeadDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Pato de cabeça vermelha");
        }

        public string Fly()
        {
            return "🕊️ Voando como um RedHeadDuck!";
        }

        public string Quack()
        {
            return "🦆 Quaaaack!";
        }
    }
}
