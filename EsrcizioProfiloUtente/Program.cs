int ReadIntInput(string question)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        return result;
    }
    else
    {
        Console.WriteLine("Il valore inserito non un numero valido");
        return 0;
    }
}

double ReadDoubleInput(string question)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();
    if (double.TryParse(input, out double result))
    {
        return result;
    }
    else
    {
        Console.WriteLine("Il valore inserito non un numero valido");
        return 0;
    }
}

string ReadStringInput(string question)
{
    Console.WriteLine(question);

    return Console.ReadLine();
}

bool ValidateStringLength(string input, int minLength)
{
    int inputLength = input.Length;
    if (inputLength < minLength)
    {
        Console.WriteLine($"Il valore inserito deve essere lungo almeno {minLength} caratteri");
        return false;
    }

    return true;
}

bool ValidateSesso(string input)
{
    bool carattereAccettato = input == "m" || input == "f";
    if (!carattereAccettato)
    {
        Console.WriteLine($"Il valore inserito deve essere 'm' o 'f'");

        return false;
    }

    return true;
}

string nome = ReadStringInput("Inserisci il tuo nome: ");

bool nomeValido = ValidateStringLength(nome, 2);
bool nomeNonValido = !nomeValido;
if (nomeNonValido)
{
    return;
}
// Equivalente a questo codice
//if (!ValidateStringLength(nome, 2))
//{
//    return;
//}


string cognome = ReadStringInput("Inserisci il tuo cognome: ");

if (!ValidateStringLength(cognome, 3))
{
    return;
}

string sesso = ReadStringInput("Inserisci il sesso (m/f): ");

if (!ValidateSesso(sesso))
{
    return;
}


string citta = ReadStringInput("Inserisci la città: ");

int eta = ReadIntInput("Inserisci l'età: ");

Console.WriteLine("\n");

Console.WriteLine("Hai inserito i seguenti dati:");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Cognome: " + cognome);
Console.WriteLine("Sesso: " + sesso);
Console.WriteLine("Città: " + citta);
Console.WriteLine("Età: " + eta);
