using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine(@"
    ████████████████████████████████████████████████████████████████████████████
    ██▀▄─██▄─█─▄██▀▄─██▄─▄███▄─▄██▀▄─██▄─▄▄▀████▀▄─██▄─▄███▄─▄─▀█▄─██─▄█▄─▀█▀─▄█
    ██─▀─███▄▀▄███─▀─███─██▀██─███─▀─███─▄─▄████─▀─███─██▀██─▄─▀██─██─███─█▄█─██
    ▀▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▀▄▄▄▀
        ");
        Console.Write("Digite o nome da banda que o álbum pertence: ");
        string bandaEscolhida = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(bandaEscolhida))
        {
            Banda banda = bandasRegistradas[bandaEscolhida];
            Console.Write("\nAgora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Console.Write($"\nDigite a nota para o álbum {tituloAlbum}: ");
                Avaliacao notaEscolhida = Avaliacao.Parse(Console.ReadLine()!);
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                album.AdicionarNota(notaEscolhida);
                Thread.Sleep(1000);
                Console.WriteLine($"\nA nota {notaEscolhida.Nota} foi atribuída ao álbum {tituloAlbum}");
                Thread.Sleep(4000);
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não existe!");
                Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {bandaEscolhida} não existe!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
        }
    }
}