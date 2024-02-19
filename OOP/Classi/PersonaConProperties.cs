namespace OOP.Classi;
internal class PersonaConProperties
{
    // le properties sono simili ai fields
    // ma sono più potenti
    // nello specifico questo sono auto-properties
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }
    public string Sesso { get; set; }

    // Altezza è privato, non può essere visto dall'esterno
    private int Altezza { get; set; }

    // possiamo modificare separatamente la visibilità del getter e del setter
    public string CodiceFiscale { get; private set; }

    public PersonaConProperties(
        string nomePersona,
        string cognomePersona,
        int etaPersona,
        string sessoPersona)
    {
        Nome = nomePersona;
        Cognome = cognomePersona;
        Eta = etaPersona;
        Sesso = sessoPersona;
        Altezza = 180;

        CodiceFiscale = $"{nomePersona}_{cognomePersona}_{etaPersona}_{sessoPersona}";
    }
}
