namespace Projeto_1.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> listaDeMusicas = new();
    private List<Avaliacao> listaDeNotas = new();

    public Album(string nome)
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
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public void AdicionarNota(Avaliacao nota)
    {
        listaDeNotas.Add(nota);
    }

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

    public void AdicionarNotaAlbum(Avaliacao nota)
    {
        listaDeNotas.Add(nota);
    }
}