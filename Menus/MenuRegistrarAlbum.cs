using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AtribuirAlbumABanda(new Album(tituloAlbum));
            Thread.Sleep(1000);
            Console.WriteLine($"\nO álbum {tituloAlbum} da banda {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não existe!");
            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
        }
    }
}