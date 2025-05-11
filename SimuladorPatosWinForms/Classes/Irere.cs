using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class Irere : Duck, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("Irerê");
        }

        public string Fly()
        {
            return "🕊️ Voando como um Irerê!";
        }
    }
}

