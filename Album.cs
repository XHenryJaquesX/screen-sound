class Album
{
    
    private List<Musica> listaDeMusicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public void AdicionarMusicaNoAlbum(Musica musica)
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibeMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum \"{Nome}\":\n");
        for (int i = 0; i < listaDeMusicas.Count; i++)
        {
            Console.WriteLine($"Música {i + 1}: {listaDeMusicas[i].Nome}");
        }
        Console.WriteLine($"Esse albúm possui {DuracaoTotal} segundos de duração\n");
    }
}