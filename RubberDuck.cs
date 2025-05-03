public class RubberDuck : Duck, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Pato de borracha");
    }

    public void Quack()
    {
        Console.WriteLine("Piii (som de borracha)");
    }
}
