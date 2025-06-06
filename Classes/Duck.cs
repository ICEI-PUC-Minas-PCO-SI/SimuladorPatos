using SimuladorPatos.Classes.Strategies;

namespace SimuladorPatos.Classes
{
    public abstract class Duck
    {
        public IFlyBehavior? FlyBehavior { get; set; }
        public IQuackBehavior? QuackBehavior { get; set; }
        public IKickBehavior? KickBehavior { get; set; }

        public abstract string Display();

        public string Swim()
        {
            return "💦 Nadando como um pato!";
        }

        public string PerformFly()
        {
            return FlyBehavior?.Fly() ?? "Este pato não voa.";
        }

        public string PerformQuack()
        {
            return QuackBehavior?.Quack() ?? "Este pato não faz som.";
        }

        public string PerformKick()
        {
            return KickBehavior?.Kick() ?? "Este pato não chuta.";
        }
    }
}