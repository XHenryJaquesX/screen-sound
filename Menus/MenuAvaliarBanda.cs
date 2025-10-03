using Projeto_1.Modelos;

namespace Projeto_1.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
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
            Banda banda = bandasRegistradas[bandaEscolhida];
            Console.Write($"\nDigite a nota para a banda {bandaEscolhida}: ");
            Avaliacao notaEscolhida = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(notaEscolhida);
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