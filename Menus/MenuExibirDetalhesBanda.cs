using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhesBanda : Menu
{
    public override void Executar(Dictionary<string, Artista> bandasRegistradas)
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
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não existe!");
            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal:");
            Console.ReadKey();
        }
    }
}