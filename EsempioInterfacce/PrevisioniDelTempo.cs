namespace EsempioInterfacce;
internal class PrevisioniDelTempo : IDisplayable
{

    private readonly string _citta;

    public PrevisioniDelTempo(string citta)
    {
        _citta = citta;
    }

    public string Title { get; } = "Previsioni del tempo";

    public string GetDisplayText()
    {
        return GetPrevisioni();
    }

    public string GetPrevisioni()
    {
        return "Previsioni per " + _citta + ": bel tempo";
    }
}
