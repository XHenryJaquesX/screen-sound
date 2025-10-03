using Projeto_1.Modelos;

namespace Projeto_1.Menus;

internal class MenuExibirDetalhesBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (banda.Media == 0)
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} ainda não recebeu notas");
            }
            else
            {
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media:F2}.");
            }
            if (banda.Albuns.Count == 0)
            {
                Console.WriteLine($"A banda {nomeDaBanda} ainda não possui albuns");
            }
            else
            {
            Console.WriteLine($"\nAlbuns da banda {nomeDaBanda}:\n");
            }
            int contador = 1;
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"Album {contador}: {album.Nome} {(album.Media == 0? "- ainda não recebeu nota" : "- possui a nota " + album.Media)}");
                contador++;
            }
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não existe!");
            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
        }
    }
}