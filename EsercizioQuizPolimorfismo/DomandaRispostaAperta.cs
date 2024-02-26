namespace EsercizioQuizPolimorfismo;
internal class DomandaRispostaAperta : Domanda
{
    private string _rispostaUtente;
    private readonly string _rispostaCorretta;


    // devo estendere il costruttore della classe base usando la keyword base
    // in questo caso, la classe base è Domanda e ha un costruttore che accetta una stringa
    public DomandaRispostaAperta(string domandaDaChiedere, string rispostaCorretta) : base(domandaDaChiedere)
    {
        _rispostaCorretta = rispostaCorretta;
    }

    public override void Ask()
    {
        // con il metodo base.Ask() chiamo il metodo Ask() della classe base
        base.Ask();

        _rispostaUtente = Console.ReadLine();
    }

    public override bool Check()
    {
        return _rispostaUtente.ToLower() == _rispostaCorretta.ToLower();
    }
}
