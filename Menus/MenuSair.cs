using Projeto_1.Modelos;

namespace Projeto_1.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nAdeus :)\n");
    }
}