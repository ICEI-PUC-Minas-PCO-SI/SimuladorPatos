using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            FlyBehavior = new NoFly();
            QuackBehavior = new Silent();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Pato de madeira";
        }
    }
}
