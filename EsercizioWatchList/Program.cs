namespace EsercizioWatchList;

internal class Program
{
    static void Main(string[] args)
    {

        var filmStore = new FilmStore();

        bool continua = true;
        while (continua)
        {
            Console.Clear();

            Console.WriteLine("Scegli cosa fare: \n" +
                "- 1. Visualizza lista film\n" +
                "- 2. Segna film come visto\n" +
                "- 3. Segna film come non visto\n" +
                "- 4. Esci");

            int scelta = ReadScelta(1, 4);

            if (scelta == 1)
            {
                // Visualizza lista film
                var listaFilm = filmStore.VisualizzaListaFilm();
                Console.WriteLine(listaFilm);
            }
            else if (scelta == 2)
            {
                Console.WriteLine("Indica l'id del film che vuoi segnare");

                var listaFilm = filmStore.VisualizzaListaFilm();
                Console.WriteLine(listaFilm);

                int idx = ReadScelta(1, filmStore.GetMaxId());

                filmStore.SegnaFilmComeVisto(idx, true);
            }
            else if (scelta == 3)
            {
                Console.WriteLine("Indica l'id del film che vuoi segnare");

                var listaFilm = filmStore.VisualizzaListaFilm();
                Console.WriteLine(listaFilm);

                int idx = ReadScelta(1, filmStore.GetMaxId());

                filmStore.SegnaFilmComeVisto(idx, false);
            }
            else if (scelta == 4)
            {
                // Esci
                continua = false;
            }

            Console.ReadLine();
        }
    }

    private static int ReadScelta(int min, int max)
    {
        int sceltaInt;
        bool ok;
        do
        {
            string scelta = Console.ReadLine();
            ok = int.TryParse(scelta, out sceltaInt);

            if (!ok)
            {
                Console.WriteLine("Inserisci un numero valido");
                continue;
            }

            if (sceltaInt < min || sceltaInt > max)
            {
                Console.WriteLine($"Inserisci un numero compreso tra {min} e {max}");
                ok = false;
            }
        }
        while (!ok);

        return sceltaInt;
    }
}
