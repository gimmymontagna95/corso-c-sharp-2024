Console.WriteLine("Invia un messaggio");
string messaggio = Console.ReadLine();

bool contieneParolaBrutta = messaggio.Contains("bruttaparola");
bool contieneParolaccia = messaggio.Contains("parolaccia");
bool contieneParolacattiva = messaggio.Contains("parolacattiva");
bool contieneLetteraMaiuscola = messaggio.ToLower() != messaggio;

bool messaggioNonValido = contieneParolaBrutta || contieneParolaccia || contieneParolacattiva || contieneLetteraMaiuscola;

if (messaggioNonValido)
{
    string messaggioModerato = messaggio
        .ToLower()
        .Replace("bruttaparola", "")
        .Replace("parolaccia", "")
        .Replace("parolacattiva", "");

    Console.WriteLine($"Il messaggio moderato è {messaggioModerato}");
}
else
{
    Console.WriteLine($"Il messaggio  è valido");
}

