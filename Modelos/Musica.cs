namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(string nome, Genero genero, Artista artista)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }
    public string Nome { get; }
    public Artista Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; }
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista.Nome}";
    public void ExibeFichaTecnicaMusica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Gênero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine($"A música está disponível no plano!");
        }
        else
        {
            Console.WriteLine($"A música não está disponível no plano!");
        }
        Console.WriteLine(DescricaoResumida);
    }
}
