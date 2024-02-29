namespace EsercizioWatchList;
internal class Film
{
    public string Titolo { get; }
    public bool Visto { get; set; }
    public string StreamingPlatform { get; set; }
    public string Genere { get; set; }

    public Film(string titolo, bool visto, string streamingPlatform, string genere)
    {
        Titolo = titolo;
        Visto = visto;
        StreamingPlatform = streamingPlatform;
        Genere = genere;
    }
}
