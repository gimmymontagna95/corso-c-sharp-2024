namespace EsempioLINQ;

internal class Program
{
    /**
     *  Stampare tutti i linguaggi con il metodo Prettify()
     *  Query che restituisce una stringa per ogni linguaggio, che include anno, nome e chief developer
     *  Query che cerca i linguaggi che si chiamano C#
     *  Query che cerca tutti i linguaggi con Microsoft come chief developer
     *  Query che cerca tutti i linguaggi che hanno come predecessore "Lisp"
     *  Query che cerca tutti i linguaggi che hanno nel nome "script"
     *  Stampare il numero di linguaggi contenuti nel DB
     *  Contare quanti linguaggi sono stati creati tra il 1995 e il 2005
     *  Stampare una stringa nel formato "NAME was invented in YEAR" per ogni linguaggio dato dalla query precedente
     */
    static void Main(string[] args)
    {
        List<Language> languages = File.ReadAllLines("./languages.tsv")
           .Skip(1)
           .Select(line => Language.FromTsv(line))
           .ToList();

        // 1. Stampare tutti i linguaggi con il metodo Prettify()

        //Select trasforma ogni elemento della lista in un altro elemento. Equivalea al map di Javascript
        List<string> prettifiedLanguages = languages.Select((l) =>
        {
            return l.Prettify();
        }).ToList();

        // equivalente a questo
        //var prettifiedLanguages = languages.Select((l) => l.Prettify()).ToList();

        // 2. Query che restituisce una stringa per ogni linguaggio, che include anno, nome e chief developer

        List<string> es2 = languages.Select((l) => $"{l.Year} - {l.Name} - {l.ChiefDeveloper}").ToList();


        // 3. Query che cerca i linguaggi che si chiamano C#

        // where non trasforma gli elementi, ma li filtra. Equivale al filter di Javascript
        List<Language> es3 = languages.Where((l) => l.Name == "C#").ToList();

        // 4. Query che cerca tutti i linguaggi con Microsoft come chief developer
        List<Language> es4 = languages.Where((l) => l.ChiefDeveloper == "Microsoft").ToList();

        // 5. Query che cerca tutti i linguaggi che hanno come predecessore "Lisp"
        List<Language> es5 = languages.Where((l) => l.Predecessors == "Lisp").ToList();

        // 6. Query che cerca tutti i linguaggi che hanno nel nome "script"
        List<Language> es6 = languages.Where((l) => l.Name.Contains("script")).ToList();


        // 7. Stampare il numero di linguaggi contenuti nel DB
        int es7 = languages.Count();
        //Console.WriteLine(es7);

        // 8. Contare quanti linguaggi sono stati creati tra il 1995 e il 2005
        int es8 = languages.Where((l => l.Year >= 1995 && l.Year <= 2005)).Count();

        // 9. Stampare una stringa nel formato "NAME was invented in YEAR" per ogni linguaggio dato dalla query precedente
        List<string> es9 = languages
            .Where((l) => l.Year >= 1995 && l.Year <= 2005)
            .Select((l) => $"{l.Name} was inveted in {l.Year}")
            .ToList();

        List<Language> es10 = languages
            .Where(l => l.Name.StartsWith("C"))
            .OrderBy(l => l.Name)
            .ToList();


        // 11. Query che conta per ogni anno quanti linguaggi sono stati creati
        var es11 = languages
            .GroupBy(l => l.Year)
            .Select(g => new LanguagesByYear
            {
                Year = g.Key,
                Count = g.Count()
            })
            .OrderBy(l => l.Year)
            .ToList();

        //Console.WriteLine(es8);
        //foreach (var language in es11)
        //{
        //    Console.WriteLine($"{language.Year}: {language.Count}");
        //}

        // 12. Query che da una lista senza duplicati di chief developers
        var es12 = languages.Select(l => l.ChiefDeveloper).Distinct().ToList();
        foreach (var language in es12)
        {
            Console.WriteLine(language);
        }

    }
}
