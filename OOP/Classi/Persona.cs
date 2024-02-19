namespace OOP.Classi;
internal class Persona
{
    // le variabili di una classe sono dette 'fields'
    // a differenza di una variabile normale, i fields di una classe devono indicare la visibilità (es. public)
    public string nome;
    public string cognome;
    public int eta;
    public string sesso;

    // possiamo porre dei vincoli sulla costruzione dell'oggetto
    // utilizzando un metodo particolare detto costruttore
    public Persona(
        string nomePersona,
        string cognomePersona,
        int etaPersona,
        string sessoPersona)
    {
        Console.WriteLine($"Costruttore chiamato con i parametri {nomePersona} {cognomePersona}");

        nome = nomePersona;
        cognome = cognomePersona;
        eta = etaPersona;
        sesso = sessoPersona;
    }
}
