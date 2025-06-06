using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Pato de cabeça vermelha";
        }
    }
}
