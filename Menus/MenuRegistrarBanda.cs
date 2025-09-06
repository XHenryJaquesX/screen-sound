using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Artista> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
    }
}