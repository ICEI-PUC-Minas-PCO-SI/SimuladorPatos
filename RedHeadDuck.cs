public class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Pato de cabeça vermelha");
    }

    public void Fly()
    {
        Console.WriteLine("Voando como um RedHeadDuck!");
    }

    public void Quack()
    {
        Console.WriteLine("Quaaaack!");
    }
}
