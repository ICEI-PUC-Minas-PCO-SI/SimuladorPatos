using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public class PatoMergulhao : Duck
    {
        public PatoMergulhao()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
            KickBehavior = new NoKick();
        }

        public override string Display()
        {
            return "Pato-Mergulhão";
        }
    }
}
