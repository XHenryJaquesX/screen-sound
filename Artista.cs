class Artista
{
    private List<Album> listaDeAlbuns = new List<Album>();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AtribuirAlbumAoArtista(Album album)
    {
        listaDeAlbuns.Add(album);
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