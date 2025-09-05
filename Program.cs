//Screen Sound

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Manu Batidão", new List<int>());

ExibirMenu();

void ExibirMenu()
{
    Console.Clear();
    ExibirTitulo();
    Console.WriteLine(@"
Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
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
            RegistrarAlbum();
            break;
        case 3:
            MostrarBandas();
            break;
        case 4:
            AvaliarBanda();
            break;
        case 5:
            ExibeDetalhesBanda();
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

void RegistrarAlbum()
{
    Console.Clear();
    Console.WriteLine(@"
█████████████████▀██████████████████████████████████████████████████████████████████████
█▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀██▀▄─██▄─▄▄▀████▀▄─██▄─▄███▄─▄─▀█▄─██─▄█▄─▀█▀─▄█
██─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄██─▀─███─▄─▄████─▀─███─██▀██─▄─▀██─██─███─█▄█─██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▀▄▄▄▀
    ");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.Write("Agora digite o título do álbum: ");
    string tituloAlbum = Console.ReadLine()!;
    //
    // Espaço reservado
    //
    Thread.Sleep(1000);
    Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(4000);
    ExibirTitulo();
}

void ExibeDetalhesBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█████████████████████████████████████████████████████████████████████████████████
█▄─▄▄─█▄─▀─▄█▄─▄█▄─▄─▀█▄─▄█▄─▄▄▀███▄─▄▄▀█▄─▄▄─█─▄─▄─██▀▄─██▄─▄███─█─█▄─▄▄─█─▄▄▄▄█
██─▄█▀██▀─▀███─███─▄─▀██─███─▄─▄████─██─██─▄█▀███─████─▀─███─██▀█─▄─██─▄█▀█▄▄▄▄─█
▀▄▄▄▄▄▀▄▄█▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀
    ");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        ExibirMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não existe!");
        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
        Console.ReadKey();
        ExibirMenu();
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█████████████████▀██████████████████████████████████████████████████████████████████████████████████
█▄─▄▄▀█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀█─▄▄─███▄─▄▄▀█▄─▄▄─███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██─▄▄▄▄█
██─▄─▄██─▄█▀█─██▄─██─██▄▄▄▄─███─████─▄─▄█─██─████─██─██─▄█▀████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██▄▄▄▄─█
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀
    ");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
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
███████████████████████████████████████████████████████████████████████████
██▀▄─██▄─█─▄██▀▄─██▄─▄███▄─▄██▀▄─██▄─▄▄▀███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀██▀▄─██
██─▀─███▄▀▄███─▀─███─██▀██─███─▀─███─▄─▄████─▄─▀██─▀─███─█▄▀─███─██─██─▀─██
▀▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀
    ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandaEscolhida = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"\nDigite a nota para a banda {bandaEscolhida}: ");
        int notaEscolhida = int.Parse(Console.ReadLine()!);
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