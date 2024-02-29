namespace EsercizioWatchList;
internal class FilmStore
{
    private readonly List<Film> _films;

    public FilmStore()
    {
        _films = new List<Film>()
        {
            new Film("Il Signore degli Anelli", true, "Netflix",  "Fantasy"),
            new Film("Harry Potter", false, "Amazon Prime", "Fantasy"),
            new Film("Star Wars", true, "Disney+", "Fantasy"),
        };
    }

    public string VisualizzaListaFilm()
    {
        var films = _films
             .Select((f, idx) => $"-{idx + 1}: {f.Titolo} - {(f.Visto ? "Visto" : "Non visto")} - {f.Genere} - {f.StreamingPlatform}")
             .ToList();

        return string.Join('\n', films);
    }

    public void SegnaFilmComeVisto(int idx, bool visto)
    {
        idx--;
        if (idx >= 0 && idx < _films.Count)
        {
            _films[idx].Visto = visto;
        }
    }

    public int GetMaxId()
    {
        return _films.Count;
    }

}
