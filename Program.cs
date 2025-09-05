using ScreenSound.Modelos;

Artista nandoReis = new("Nando Reis");
nandoReis.AdicionarNotaArtista(new Avaliacao (10));
nandoReis.AdicionarNotaArtista(new Avaliacao (10));
nandoReis.AdicionarNotaArtista(new Avaliacao (10));

Artista manuBatidao = new("Manu Batidão");
manuBatidao.AdicionarNotaArtista(new Avaliacao (4));
manuBatidao.AdicionarNotaArtista(new Avaliacao (9));
manuBatidao.AdicionarNotaArtista(new Avaliacao (7));

Dictionary<string, Artista> bandasRegistradas = new();
bandasRegistradas.Add(nandoReis.Nome, nandoReis);
bandasRegistradas.Add(manuBatidao.Nome, manuBatidao);

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

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("\nAgora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Artista artista = bandasRegistradas[nomeDaBanda];
        artista.AtribuirAlbumAoArtista(new Album(tituloAlbum));
        Thread.Sleep(1000);
        Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
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
        Artista artista = bandasRegistradas[nomeDaBanda];
        if (artista.Media == 0)
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} ainda não recebeu notas");
        }
        else
        {
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {artista.Media:F2}.");
        }
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
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
    Artista artista = new(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, artista);
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
        Artista artista = bandasRegistradas[bandaEscolhida];
        Console.Write($"\nDigite a nota para a banda {bandaEscolhida}: ");
        Avaliacao notaEscolhida = Avaliacao.Parse(Console.ReadLine()!);
        artista.AdicionarNotaArtista(notaEscolhida);
        Thread.Sleep(1000);
        Console.WriteLine($"\nA nota {notaEscolhida.Nota} foi atribuída a banda {bandaEscolhida}");
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