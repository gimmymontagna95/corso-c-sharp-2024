namespace ReferenceEValueTypes;

internal class Program
{
    static void Main(string[] args)
    {

        // esistono 2 tipi di dato: value type e reference type
        // i value type sono allocati nello stack,
        // e sono immutabili e vengono copiati ogni volta che li assegna ad una variabile

        // i reference type sono allocati nello heap,
        // e vengono passati per riferimento (by reference)

        // i value type sono: bool, char, double, float, int, long, etc.
        int a = 10;
        int b = a; // b è una copia di a
        a = 20;
        int c = a;
        // b rimane 10, mentre a diventa 20
        Console.WriteLine($"a: {a}, b: {b}");


        // i reference type sono: class, interface, array, string
        ClasseDiTest c1 = new ClasseDiTest()
        {
            Valore = 10
        };
        ClasseDiTest c2 = c1; // c2 punta allo stesso oggetto di c1

        ClasseDiTest c3 = new ClasseDiTest()
        {
            Valore = c1.Valore
        };

        c1.Valore = 20;

        Console.WriteLine($"c1.Valore: {c1.Valore}, c2.Valore: {c2.Valore}, c3.Valore: {c3.Valore}");


        // Es. di passaggio per valore
        int x = 10;
        Incrementa(x);
        Console.WriteLine($"x: {x}"); // x rimane 10

        // Es. di passaggio per riferimento
        ClasseDiTest c4 = new ClasseDiTest()
        {
            Valore = 10
        };
        IncrementaRef(c4);
        Console.WriteLine($"c4.Valore: {c4.Valore}"); // c4.Valore diventa 11

        // è un meccanismo prono ad errore, si rischia di modificare un oggetto senza volerlo
        // buona pratica è crecare di evitare di modificare gli oggetti passati come argomenti

        ClasseDiTest c5 = new ClasseDiTest()
        {
            Valore = 10
        };
        var c6 = IncrementaRefMaMeglio(c5);
        Console.WriteLine($"c5.Valore: {c5.Valore}, c6.Valore: {c6.Valore}"); // c5.Valore rimane 10


        // L'uguagliaza tra oggetti confronta i riferimenti, non i valori
        ClasseDiTest c7 = new ClasseDiTest()
        {
            Valore = 10
        };
        ClasseDiTest c8 = new ClasseDiTest()
        {
            Valore = 10
        };

        Console.WriteLine($"c7 == c8: {c7 == c8}"); // false

        ClasseDiTest c9 = c7;
        Console.WriteLine($"c7 == c9: {c7 == c9}"); // true



        // c'è un'eccezione: string
        // string è un reference type, ma è immutabile
        string s1 = "prova";
        ModificaStringa(s1);
        Console.WriteLine($"s1: {s1}"); // s1 rimane "prova"

        string s2 = s1;
        Console.WriteLine($"s1 == s2: {s1 == s2}"); // dovrebbe dare falso, ma fa eccezione e da vero


        // come valore di default per i reference type c'è null
        ClasseDiTest c10 = null;
        if (c10 != null)
        {
            Console.WriteLine(c10.Valore);
        }
    }

    public static void Incrementa(int a)
    {
        a = a + 1;
    }

    public static void IncrementaRef(ClasseDiTest a)
    {
        a.Valore = a.Valore + 1;
    }

    // meglio restituire un nuovo oggetto con la modifica applicata
    public static ClasseDiTest IncrementaRefMaMeglio(ClasseDiTest a)
    {
        ClasseDiTest c = new ClasseDiTest()
        {
            Valore = a.Valore + 1
        };
        return c;
    }

    public static void ModificaStringa(string s)
    {
        s = "ciao";
    }
}
