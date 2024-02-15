void MetodoVoid()
{
    Console.WriteLine("Sono dentro il metodo MetodoVoid");
}

void MetodoVoidConInput(string input)
{
    Console.WriteLine("Sono dentro il metodo MetodoVoidConInput");
    Console.WriteLine("L'input è: " + input);
}

int MetodoAdd(int a, int b)
{
    int risultato = a + b;

    return risultato;
}

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

MetodoVoid();
MetodoVoid();

MetodoVoidConInput("stringa di test");
MetodoVoidConInput("stringa di test seconda volta");

int risultatoAdd = MetodoAdd(5, 7);
Console.WriteLine("Il risultato dell'addizione è: " + risultatoAdd);

//int inputNumericoDellUtente1 = ReadIntInput("Inserisci il primo valore");
//int inputNumericoDellUtente2 = ReadIntInput("Inserisci il secondo valore");
//int inputNumericoDellUtente3 = ReadIntInput("Inserisci il terzo valore");

//Console.WriteLine($"Hai inserito {inputNumericoDellUtente1} {inputNumericoDellUtente2} {inputNumericoDellUtente3}");


/** -------------------------- */
// Parametri opzionali
// question è un parametro opzionale con valore di default ""
string ReadStringInputOpzionle(string question = "")
{
    if (question.Length > 0)
    {
        Console.WriteLine(question);
    }

    return Console.ReadLine();
}

// Possiamo non specificare il parametro opzionale (assume il valore di default)
//string inputStringaDellUtente1 = ReadStringInputOpzionle();


// Possiamo indicare più parametri opzionali, ma devono essere tutti alla fine
bool ValidateStringLength(string input, int minLength = 0, int maxLength = 200)
{
    int inputLength = input.Length;
    if (inputLength < minLength)
    {
        Console.WriteLine($"Il valore inserito deve essere lungo almeno {minLength} caratteri");
        return false;
    }

    if (inputLength > maxLength)
    {
        Console.WriteLine($"Il valore inserito deve essere lungo al massimo {maxLength} caratteri");
        return false;
    }

    return true;
}

bool validazione1 = ValidateStringLength("ciao");
bool validazione2 = ValidateStringLength("ciao", 3);
bool validazione3 = ValidateStringLength("ciao", 3, 5);

// Name arguments
// Possiamo specificare il nome del parametro a cui stiamo passando il valore
// Se non specificato, l'ordine dei parametri è importante ed è quello definito nella firma del metodo
bool validazione4 = ValidateStringLength(input: "ciao", minLength: 3, maxLength: 5);

// Possiamo specificare solo alcuni parametri e in qualsiasi ordine
bool validazione5 = ValidateStringLength(input: "ciao", maxLength: 5);

// Non possiamo specificare solo alcuni parametri e in qualsiasi ordine
bool validazione6 = ValidateStringLength(input: "ciao", 5);
bool validazione7 = ValidateStringLength("ciao", maxLength: 5);


/** -------------------------- */
// Parametri out
// Possiamo passare un parametro out per restituire più di un valore

// ES
// due output differenti: controlloSuccesso (return del metodo) e numeroParsato (parametro out)
bool controlloSuccesso = int.TryParse("5", out int numeroParsato);

bool ValidateStringLengthMultipleOut(string input, int minLength, int maxLength, out string errorMessage)
{
    int inputLength = input.Length;
    if (inputLength < minLength)
    {
        // dobbiamo assegnare un valore a errorMessage prima di uscire dal metodo
        errorMessage = $"Il valore inserito deve essere lungo almeno {minLength} caratteri";

        return false;
    }

    if (inputLength > maxLength)
    {
        errorMessage = $"Il valore inserito deve essere lungo al massimo {maxLength} caratteri";

        return false;
    }

    // dobbiamo assegnare un valore a errorMessage prima di uscire dal metodo in tutti i casi
    errorMessage = "";
    return true;
}

bool risultatoValidazione10 = ValidateStringLengthMultipleOut("ciao a tutti", 3, 5, out string errorMessage10);
Console.WriteLine($"il risultato del metodo è {risultatoValidazione10}, il messaggio di error è {errorMessage10}");


