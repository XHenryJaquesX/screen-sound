using Projeto_1.Modelos;

namespace Projeto_1.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
    }
}