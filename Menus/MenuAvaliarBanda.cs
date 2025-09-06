using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Artista> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
        }
        else
        {
            Console.WriteLine($"\nA banda {bandaEscolhida} não existe!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
        }
    }
}