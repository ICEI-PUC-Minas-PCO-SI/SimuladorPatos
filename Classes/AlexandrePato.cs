using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class AlexandrePato : Duck
    {
        public AlexandrePato()
        {
            FlyBehavior = new NoFly();
            QuackBehavior = new Silent();
            KickBehavior = new KickBall();
        }

        public override string Display()
        {
            return "Alexandre Pato";
        }
    }
}
