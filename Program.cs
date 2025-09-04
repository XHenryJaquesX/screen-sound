//Screen Sound

Dictionary<string, List<float>> bandasRegistradas = new Dictionary<string, List<float>>();
bandasRegistradas.Add("Manu Batidão", new List<float>());

ExibirMenu();

void ExibirTitulo()
{
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    Console.Clear();
    ExibirTitulo();
    Console.WriteLine(@"
Digite 1 para registrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite -1 para sair
    ");
    Console.Write("Escolha: ");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
        break;
        case 2:
            MostrarBandas();
        break;
        case 3:
            AvaliarBanda();
        break;
        case 4:
            MostrarMediaBanda();
        break;
        case -1:
            Console.WriteLine("\nAdeus :)\n");
        break;
        default:
            Console.WriteLine("Opção inválida!!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
        break;
    }

}

void RegistrarBanda()
{
    string mensagemRegistroDeBanda = "Boas vindas ao Registro de Bandas\n";
    Console.Clear();
    Console.WriteLine(@"
█████████████████▀██████████████████████████████████████████████████████████████████████████████████
█▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀█─▄▄─███▄─▄▄▀█▄─▄▄─███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██─▄▄▄▄█
██─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄█─██─████─██─██─▄█▀████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██▄▄▄▄─█
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀
    ");
    Console.WriteLine(mensagemRegistroDeBanda);
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<float>());
    Thread.Sleep(2000);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!\n");
    Thread.Sleep(2000);
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█████████████████████████████████████████████████████████▀███████████████████████████████████████████████
█▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██─▄▄▄▄███▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀██▀▄─██▄─▄▄▀██▀▄─██─▄▄▄▄█
██─▄─▀██─▀─███─█▄▀─███─██─██─▀─██▄▄▄▄─████─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄██─▀─███─██─██─▀─██▄▄▄▄─█
▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀
    ");
    Thread.Sleep(1000);
    int contador = 1;
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {contador}: {banda}");
        contador++;
    }
    Console.Write("\nDigite qualquer tecla para voltar ao menu principal: ");
    Console.ReadKey();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█████████████████▀█████████████████████████████████████████████████████████████████████
█▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀██▀▄─██▄─▄▄▀███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██
██─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄██─▀─███─▄─▄████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀
    ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandaEscolhida = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"\nDigite a nota para a banda {bandaEscolhida}: ");
        float notaEscolhida = float.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaEscolhida].Add(notaEscolhida);
        Thread.Sleep(1000);
        Console.WriteLine($"\nA nota {notaEscolhida} foi atribuída a banda {bandaEscolhida}");
        Thread.Sleep(4000);
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} não existe!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
        Console.ReadKey();
        ExibirMenu();
    }
}

void MostrarMediaBanda()
{
    Console.Clear();
    Console.WriteLine(@"
███████████████████████████████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄▄─█▄─▄▄▀█▄─▄██▀▄─████▄─▄▄▀██▀▄─████▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██
██─█▄█─███─▄█▀██─██─██─███─▀─█████─██─██─▀─█████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██
▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀
    ");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string bandaEscolhida = Console.ReadLine()!;
    Thread.Sleep(1000);
    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.WriteLine($"\nA média de notas da banda {bandaEscolhida} é {bandasRegistradas[bandaEscolhida].Average():F2}!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
        Console.ReadKey();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} não existe!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
        Console.ReadKey();
        ExibirMenu();
    }
}