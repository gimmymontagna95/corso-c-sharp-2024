namespace EsempioLINQ;

internal class Program
{
    static void Main(string[] args)
    {
        List<Language> languages = File.ReadAllLines("./languages.tsv")
           .Skip(1)
           .Select(line => Language.FromTsv(line))
           .ToList();
    }
}
