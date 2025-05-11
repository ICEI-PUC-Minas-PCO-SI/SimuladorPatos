using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class PatoMergulhao : Duck, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Pato-Mergulhão");
        }

        public string Fly()
        {
            return "🕊️ Voando como um Pato-Mergulhão!";
        }

        public string Quack()
        {
            return "🦆 Quack-quack!";
        }
    }
}

