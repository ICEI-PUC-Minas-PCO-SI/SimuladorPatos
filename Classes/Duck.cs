using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        public IKickBehavior KickBehavior { get; set; }

        public abstract string Display();

        public string Swim()
        {
            return "💦 Nadando como um pato!";
        }

        public string PerformFly()
        {
            return FlyBehavior?.Fly();
        }

        public string PerformQuack()
        {
            return QuackBehavior?.Quack();
        }

        public string PerformKick()
        {
            return KickBehavior?.Kick();
        }
    }
}
