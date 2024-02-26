namespace EsercizioQuizPolimorfismo;
internal class Quiz
{
    private readonly Domanda[] _domande;

    public Quiz(Domanda[] domande)
    {
        this._domande = domande;
    }


    public void AskAll()
    {
        foreach (var domanda in _domande)
        {
            domanda.Ask();
        }
    }

    public int ContaRisposteCorrette()
    {
        int count = 0;
        foreach (var domanda in _domande)
        {
            if (domanda.Check())
            {
                count++;
            }
        }

        return count;
    }
}
