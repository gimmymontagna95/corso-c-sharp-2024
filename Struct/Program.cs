namespace Struct;

internal class Program
{
    static void Main(string[] args)
    {
        StructDiProva s1 = new StructDiProva
        {
            X = 10,
            Y = 20
        };

        StructDiProva s2 = s1;
        s1.X = 30;

        Console.WriteLine($"s1.X = {s1.X}  s2.X = {s2.X}");
        StructDiProva s3 = new StructDiProva
        {
            X = 10,
            Y = 20
        };


        // DateTime sono una struct molto popolare e utile
        DateTime data = new DateTime(2024, 02, 29);
        DateTime dataDiOggi = DateTime.Now;
        Console.WriteLine(data);
        Console.WriteLine(dataDiOggi);
        var a = data == dataDiOggi;


        // Record
        RecordDiEsempio r1 = new RecordDiEsempio
        {
            X = 10,
            Y = 20
        };

        RecordDiEsempio r2 = new RecordDiEsempio
        {
            X = 10,
            Y = 20
        };

        Console.WriteLine(r1 == r2); // True

        // modifica di un record
        // modo 1: creo un nuovo record con i valori modificati
        RecordDiEsempio r3 = new RecordDiEsempio
        {
            X = 40,
            Y = r1.Y
        };

        // modo 2: crea un nuovo record con i valori modificati con with
        RecordDiEsempio r4 = r1 with { X = 30 };

        // Enumeratori

        EnumeratoreDiEsempio e1 = EnumeratoreDiEsempio.Valore2;
        EnumeratoreDiEsempio e2 = EnumeratoreDiEsempio.Valore2;

        Console.WriteLine(e2 == e1); // True

    }
}
