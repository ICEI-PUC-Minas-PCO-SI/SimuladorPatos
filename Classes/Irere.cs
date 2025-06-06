using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class Irere : Duck
    {
        public Irere()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Silent();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Irerê";
        }
    }
}
