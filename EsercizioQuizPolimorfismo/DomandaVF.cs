namespace EsercizioQuizPolimorfismo;
internal class DomandaVF : Domanda
{
    private readonly bool _rispostaCorretta;
    private bool _rispostaUtente;

    public DomandaVF(string domandaDaChiedere, bool rispostaCorretta) : base(domandaDaChiedere)
    {
        _rispostaCorretta = rispostaCorretta;
    }

    public override void Ask()
    {
        base.Ask();

        Console.WriteLine("Inserisci V per vero e F per falso");
        var risposta = Console.ReadLine();
        _rispostaUtente = risposta.ToLower() == "v";
    }

    public override bool Check()
    {
        return _rispostaUtente == _rispostaCorretta;
    }
}
