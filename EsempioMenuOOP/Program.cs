namespace EsempioMenuOOP;

internal class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        Console.WriteLine("Benvenuto al ristorante");
        Console.WriteLine($"Ecco il nostro menu:\n{menu}");

        Console.WriteLine("Cosa vuole ordinare?");
        string scelta = Console.ReadLine();

        if (!menu.CheckHasItem(scelta))
        {
            Console.WriteLine("Mi dispiace, non abbiamo questo piatto");
            return;
        }

        string[] filteredMenu = menu.Filter(scelta);

        Console.WriteLine("Ecco cosa abbiamo che soddisfa la tua richiesta:");
        foreach (var item in filteredMenu)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
