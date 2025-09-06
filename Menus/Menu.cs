
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}