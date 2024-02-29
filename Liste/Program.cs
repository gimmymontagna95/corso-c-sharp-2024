namespace Liste;

internal class Program
{
    static void Main(string[] args)
    {
        // fino ad ora abbiamo usato array
        int[] arrayDiInt = new int[] { 20, 45, 2, 4 };

        // sono difficili da usare per collezioni dinamiche (cambiare il numero di elementi)

        // le liste sono molto più flessibili
        // il tipo di dato è specificato tra <>
        List<int> listDiInt = new List<int> { 20, 45, 2, 4 };

        PrintList(listDiInt);

        // aggiungere un elemento
        listDiInt.Add(10);
        listDiInt.Insert(2, 100);
        listDiInt.AddRange(new int[] { 200, 300, 400 });

        PrintList(listDiInt);

        // rimuovere un elemento
        listDiInt.Remove(2);
        listDiInt.RemoveAt(0);

        PrintList(listDiInt);

    }

    public static void PrintList<T>(List<T> values)
    {
        Console.WriteLine();
        foreach (var value in values)
        {
            Console.WriteLine($"{value}");
        }
    }
}
