using System;

class Program
{
    static void Main()
    {
        Duck[] patos = {
            new RedHeadDuck(),
            new MallardDuck(),
            new RubberDuck(),
            new WoodenDuck()
        };

        foreach (var pato in patos)
        {
            pato.Display();
            pato.Swim();

            if (pato is IQuackable quackable)
                quackable.Quack();

            if (pato is IFlyable flyable)
                flyable.Fly();

            Console.WriteLine("--------------");
        }
    }
}
