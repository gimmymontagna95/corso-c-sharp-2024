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

int inputNumericoDellUtente1 = ReadIntInput("Inserisci il primo valore");
int inputNumericoDellUtente2 = ReadIntInput("Inserisci il secondo valore");
int inputNumericoDellUtente3 = ReadIntInput("Inserisci il terzo valore");

Console.WriteLine($"Hai inserito {inputNumericoDellUtente1} {inputNumericoDellUtente2} {inputNumericoDellUtente3}");