using ScreenSound.Modelos;
using ScreenSound.Menus;

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

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhesBanda());
opcoes.Add(-1, new MenuSair());


void ExibirMenu()
{
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    Console.Clear();
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
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

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu exibirMenuEscolhido = opcoes[opcaoEscolhida];
        exibirMenuEscolhido.Executar(bandasRegistradas);
        if(opcaoEscolhida != -1) ExibirMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida!!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();