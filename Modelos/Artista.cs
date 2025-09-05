namespace ScreenSound.Modelos;

internal class Artista
{
    private List<Album> listaDeAlbuns = new List<Album>();
    private List<Avaliacao> listaDeNotas = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public double Media
    {
        get
        {
            if (listaDeNotas.Count == 0)
            {
                return 0;
            }
            else
            {
                return listaDeNotas.Average(a => a.Nota);
            }
        }
    }

    public void AtribuirAlbumAoArtista(Album album)
    {
        listaDeAlbuns.Add(album);
    }

    public void AdicionarNotaArtista(Avaliacao nota)
    {
        listaDeNotas.Add(nota);
    }

    public void ExibirAlbunsDoArtirsta()
    {
        Console.WriteLine($"Esses são os albuns do artista {Nome}\n");
        for (int i = 0; i < listaDeAlbuns.Count; i++)
        {
            Console.WriteLine($"Album {i + 1}: {listaDeAlbuns[i].Nome}");
        }
    }
}