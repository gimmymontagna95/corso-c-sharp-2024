﻿namespace EsempioMenuOOP;

internal class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Dispensa dispensa = new Dispensa();

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

        if (filteredMenu.Length == 1)
        {
            string piatto = filteredMenu[0];
            MenuItem menuItem = menu.GetMenuItem(piatto);
            Console.WriteLine($"Vuole ordinare questo piatto {menuItem}");

            bool ingredientiSufficienti = dispensa.CheckHasIngredienti(menuItem);

            if (ingredientiSufficienti)
            {
                Console.WriteLine("Gli ingredienti sono disponibili, procedo con l'ordine");
            }
            else
            {
                Console.WriteLine("Mi dispiace, non abbiamo gli ingredienti per preparare questo piatto");
            }
        }
    }
}
