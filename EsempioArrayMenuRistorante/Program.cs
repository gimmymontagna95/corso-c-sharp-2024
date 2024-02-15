string[] menu = new string[]
{
    "Insalata triste",
    "Pasta al pomodoro",
    "Pasta al ragù",
    "Pasta al pesto",
    "Pizza margherita",
    "Pizza marinara",
    "Pizza quattro stagioni",
    "Tiramisù",
    "Panna cotta",
    "Gelato al cioccolato",
    "Gelato alla vaniglia",
    "Acqua",
    "Birra",
    "Caffè"
};

Console.WriteLine("Benvenuto al ristorante\nCosa vuole ordinare?");
string scelta = Console.ReadLine();

string sceltaTrovata = Array.Find(menu, (voceDelMenu) =>
{
    string voceDelMenuMinuscolo = voceDelMenu.ToLower();
    string sceltaMinuscola = scelta.ToLower();

    return voceDelMenuMinuscolo.Contains(sceltaMinuscola);
});

// se sceltaTrovata è null, vuol dire che non abbiamo trovato il piatto
// string.IsNullOrWhiteSpace è comodo per controllare se una stringa è null o vuota o contiene solo spazi
if (string.IsNullOrWhiteSpace(sceltaTrovata))
{
    Console.WriteLine("Mi dispiace, non abbiamo questo piatto");
    return;
}

Console.WriteLine($"Abbia a dispozione un {sceltaTrovata}");