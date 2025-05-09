using SimuladorPatos.Classes;
using SimuladorPatos.Interfaces;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        //Duck[] patos = {
        //    new RedHeadDuck(),
        //    new MallardDuck(),
        //    new RubberDuck(),
        //    new WoodenDuck()
        //};

        //foreach (var pato in patos)
        //{
        //    pato.Display();
        //    pato.Swim();

        //    if (pato is IQuackable quackable)
        //        quackable.Quack();

        //    if (pato is IFlyable flyable)
        //        flyable.Fly();

        //    Console.WriteLine("--------------");
        //}


        Console.WriteLine("Seja bem vindo(a) ao Simulador de Patos!");

        

        int opcaoEscolhida;
        string opcao, opcaoPato;
        Boolean opcaoPatoValida = true;

        Duck pato = null;

        do
        {
            Menu();
            opcao = Console.ReadLine();

            if (int.TryParse(opcao, out opcaoEscolhida))
            {
                Console.Clear();
                switch (opcaoEscolhida)
                {
                    case 1:
                        pato = new MallardDuck();
                        pato.Display();
                        break;
                    case 2:
                        pato = new RedHeadDuck();
                        pato.Display();
                        break;
                    case 3:
                        pato = new RubberDuck();
                        pato.Display();
                        break;
                    case 4:
                        pato = new WoodenDuck();
                        pato.Display();
                        break;
                    case 5:
                        pato = new AlexandrePato();
                        pato.Display();
                        break;
                    case 6:
                        pato = new Irere();
                        pato.Display();
                        break;
                    case 7:
                        pato = new PatoMergulhao();
                        pato.Display();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
    
                do {
                    MenuOpcoes(pato);
                    opcaoPato = Console.ReadLine();

                    switch (opcaoPato.ToLower())
                    {
                        case "n":
                            pato.Swim();
                            break;
                        case "v":
                            if (pato is IFlyable flyable)
                                flyable.Fly();
                            else
                                opcaoPatoValida = false;
                            break;
                        case "q":
                            if (pato is IQuackable quackable)
                                quackable.Quack();
                            else
                                opcaoPatoValida = false;
                            break;
                        case "c":
                            if (pato is IKickable kickable)
                                kickable.Kick();
                            else
                                opcaoPatoValida = false;
                            break;
                        default:
                            opcaoPatoValida = false;

                            break;
                    }
                } while (opcaoPatoValida);
                
            } else if (opcao.ToLower() != "x")
            {
               
                throw new Exception("Opção inválida");
            }
            pato = null;
        } while (opcao.ToLower() != "x");
        

    }

    public static void Menu()
    {
        Console.WriteLine("-- Selecione um Pato --");
        Console.WriteLine("(1) - Pato Real");
        Console.WriteLine("(2) - Pato Cabeça Vermelha");
        Console.WriteLine("(3) - Pato de Borracha");
        Console.WriteLine("(4) - Pato Carolino");
        Console.WriteLine("(5) - Alexandre Pato");
        Console.WriteLine("(6) - Irerê");
        Console.WriteLine("(7) - Pato Mergulhão");
        Console.WriteLine("(x) - Sair");
        Console.Write("Opção: ");
        
    }

    public static void MenuOpcoes(Duck pato)
    {
        //    pato.Swim();
        Console.WriteLine("-- Opções --");
        Console.WriteLine("(n) - Nadar");

        if (pato is IQuackable quackable)
            Console.WriteLine("(q) - Grasnar");

        if (pato is IFlyable flyable)
            Console.WriteLine("(v) - Voar");

        if (pato is IKickable kickable)
            Console.WriteLine("(c) - Chutar");

        Console.WriteLine("Aperte qualquer outra opção para sair");

        Console.Write("Opção: ");
    }
}
