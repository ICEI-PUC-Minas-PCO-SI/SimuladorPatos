using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Pato-real (Mallard)";
        }
    }
}
