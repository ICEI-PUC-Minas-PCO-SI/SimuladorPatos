using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class RubberDuck : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Pato de borracha");
        }

        public string Quack()
        {
            return "🦆 Piii (som de borracha)";
        }
    }
}
