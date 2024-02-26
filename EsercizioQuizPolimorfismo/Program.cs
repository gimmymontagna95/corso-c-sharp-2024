namespace EsercizioQuizPolimorfismo;

internal class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz(
            new Domanda[]
            {
                new DomandaVF("Domanda 1", true),
                new DomandaVF("Domanda 2", false),
                new DomandaRispostaAperta("Domanda 3", "Risposta 3"),
            }
        );

        quiz.AskAll();

        int risposteCorrette = quiz.ContaRisposteCorrette();
        Console.WriteLine($"Hai risposto correttamente a {risposteCorrette} domande");
    }
}
