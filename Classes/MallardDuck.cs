public class MallardDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Pato-real (Mallard)");
    }

    public void Fly()
    {
        Console.WriteLine("Voando como um MallardDuck!");
    }

    public void Quack()
    {
        Console.WriteLine("Quack-quack!");
    }
}
