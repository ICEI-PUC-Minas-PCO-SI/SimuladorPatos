using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new NoFly();
            QuackBehavior = new Squeak();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Pato de borracha";
        }
    }
}
