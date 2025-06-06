namespace SimuladorPatos.Classes.Strategies
{
    public class NoFly : IFlyBehavior
    {
        public string Fly() => "❌ Este pato não pode voar.";
    }
}
