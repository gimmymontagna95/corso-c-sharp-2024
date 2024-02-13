Console.WriteLine("Inserisci il tuo nome: ");
string nome = Console.ReadLine();

int lunghezzaNome = nome.Length;
if (lunghezzaNome < 2)
{
    Console.WriteLine("Il nome deve essere lungo almeno 2 caratteri");

    return;
}

Console.Write("Inserisci il tuo cognome: ");
string cognome = Console.ReadLine();

int lunghezzaCognome = cognome.Length;
if (lunghezzaCognome < 2)
{
    Console.WriteLine("Il cognome deve essere lungo almeno 2 caratteri");

    return;
}

Console.Write("Inserisci il sesso (m/f): ");
string sesso = Console.ReadLine();

bool carattereAccettato = sesso == "m" || sesso == "f";
bool inputValido = sesso.Length == 1 && carattereAccettato;
if (!inputValido)
{
    Console.WriteLine($"Il sesso deve essere lungo esattamente 1 carattere");

    return;
}


Console.Write("Inserisci la città: ");
string citta = Console.ReadLine();

Console.WriteLine("Inserisci l'età: ");
string eta = Console.ReadLine();
bool etaEUnNumeroValido = int.TryParse(eta, out int etaConvertita);

if (etaEUnNumeroValido == false)
{
    Console.WriteLine("L'età deve essere un numero");

    return;
}

Console.WriteLine("\n");

Console.WriteLine("Hai inserito i seguenti dati:");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Cognome: " + cognome);
Console.WriteLine("Sesso: " + sesso);
Console.WriteLine("Città: " + citta);
