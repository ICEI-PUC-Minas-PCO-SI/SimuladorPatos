using SimuladorPatosWinForms.Interfaces;

namespace SimuladorPatosWinForms.Classes
{
    public class AlexandrePato : Duck, IKickable
    {
        public string Kick()
        {
            return "⚽ Alexandre Pato chuta para o gol!";
        }

        public override void Display()
        {
            Console.WriteLine("Alexandre Pato");
        }
    }
}
