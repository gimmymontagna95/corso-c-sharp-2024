namespace EsercizioQuizPolimorfismo;
internal abstract class Domanda
{
    // protected è come private ma visibile alle classi figlie
    protected readonly string _domandaDaChiedere;

    // anche se la classe è astratta, posso avere un costruttore
    // le classi che eriditano da questa classe dovranno chiamare questo costruttore
    protected Domanda(string domandaDaChiedere)
    {
        this._domandaDaChiedere = domandaDaChiedere;
    }

    public virtual void Ask()
    {
        Console.WriteLine(_domandaDaChiedere);
    }

    public abstract bool Check();
}
