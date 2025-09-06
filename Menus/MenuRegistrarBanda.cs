using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
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
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Thread.Sleep(2000);
        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!\n");
        Thread.Sleep(2000);
    }
}