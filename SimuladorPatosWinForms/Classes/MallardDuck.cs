using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Pato-real (Mallard)");
        }

        public string Fly()
        {
            return "🕊️ Voando como um MallardDuck!";
        }

        public string Quack()
        {
            return "🦆 Quack-quack!";
        }
    }
}
