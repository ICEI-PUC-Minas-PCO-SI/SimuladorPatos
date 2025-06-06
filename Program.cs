using SimuladorPatos.Classes;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎮 Seja bem-vindo(a) ao SIMULADOR DE PATOS!");

        string opcao;
        Duck patoSelecionado = null;

        do
        {
            MostrarMenuSelecao();

            opcao = Console.ReadLine()?.Trim().ToLower();
            if (opcao == "x") break;

            patoSelecionado = CriarPato(opcao);

            if (patoSelecionado == null)
            {
                Console.WriteLine("Opção inválida. Pressione ENTER para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            Console.Clear();
            Console.WriteLine($"Você selecionou: {patoSelecionado.Display()}");
            Console.WriteLine("\n💡 Habilidades disponíveis:");

            if (patoSelecionado.FlyBehavior is not null && !(patoSelecionado.FlyBehavior is SimuladorPatos.Classes.Strategies.NoFly))
                Console.WriteLine("- Voar");
            if (patoSelecionado.QuackBehavior is not null && !(patoSelecionado.QuackBehavior is SimuladorPatos.Classes.Strategies.Silent))
                Console.WriteLine("- Grasnar");
            if (patoSelecionado.KickBehavior is not null && !(patoSelecionado.KickBehavior is SimuladorPatos.Classes.Strategies.NoKick))
                Console.WriteLine("- Chutar");
            Console.WriteLine("- Nadar");

            Console.Write("\nDeseja escolher esse pato? (s/n): ");
            var confirmacao = Console.ReadLine()?.Trim().ToLower();

            if (confirmacao != "s") continue;

            string acao;
            do
            {
                Console.Clear();
                Console.WriteLine("🐤 Você está controlando: " + patoSelecionado.Display());
                Console.WriteLine("\n-- Comandos --");
                Console.WriteLine("[n] Nadar");

                if (patoSelecionado.QuackBehavior is not null && !(patoSelecionado.QuackBehavior is SimuladorPatos.Classes.Strategies.Silent))
                    Console.WriteLine("[q] Grasnar");
                if (patoSelecionado.FlyBehavior is not null && !(patoSelecionado.FlyBehavior is SimuladorPatos.Classes.Strategies.NoFly))
                    Console.WriteLine("[v] Voar");
                if (patoSelecionado.KickBehavior is not null && !(patoSelecionado.KickBehavior is SimuladorPatos.Classes.Strategies.NoKick))
                    Console.WriteLine("[c] Chutar");

                Console.WriteLine("[m] Voltar para seleção de pato");
                Console.Write("Escolha uma ação: ");
                acao = Console.ReadLine()?.Trim().ToLower();

                Console.Clear();
                switch (acao)
                {
                    case "n":
                        Console.WriteLine(patoSelecionado.Swim());
                        break;
                    case "q":
                        Console.WriteLine(patoSelecionado.PerformQuack());
                        break;
                    case "v":
                        Console.WriteLine(patoSelecionado.PerformFly());
                        break;
                    case "c":
                        Console.WriteLine(patoSelecionado.PerformKick());
                        break;
                    case "m":
                        Console.WriteLine("Voltando ao menu de seleção...");
                        break;
                    default:
                        Console.WriteLine("Ação inválida.");
                        break;
                }

                if (acao != "m")
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (acao != "m");
        }
        while (opcao != "x");

        Console.WriteLine("👋 Obrigado por jogar o Simulador de Patos!");
    }

    static void MostrarMenuSelecao()
    {
        Console.WriteLine("\n=== Escolha seu PATO! ===");
        Console.WriteLine("[1] Pato Real");
        Console.WriteLine("[2] Pato Cabeça Vermelha");
        Console.WriteLine("[3] Pato de Borracha");
        Console.WriteLine("[4] Pato Carolino");
        Console.WriteLine("[5] Alexandre Pato");
        Console.WriteLine("[6] Irerê");
        Console.WriteLine("[7] Pato Mergulhão");
        Console.WriteLine("[x] Sair");
        Console.Write("Digite o número do pato: ");
    }

    static Duck CriarPato(string opcao)
    {
        return opcao switch
        {
            "1" => new MallardDuck(),
            "2" => new RedHeadDuck(),
            "3" => new RubberDuck(),
            "4" => new WoodenDuck(),
            "5" => new AlexandrePato(),
            "6" => new Irere(),
            "7" => new PatoMergulhao(),
            _ => null
        };
    }
}
