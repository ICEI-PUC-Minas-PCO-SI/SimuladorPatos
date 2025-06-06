namespace SimuladorPatos.Classes.Strategies
{
    public class NoKick : IKickBehavior
    {
        public string Kick() => "❌ Este pato não chuta.";
    }
}
