bool InputUtente()
{

    bool inputCorretto = false;
    bool inputBool = false;
    while (!inputCorretto)
    {
        Console.WriteLine("Inserisci s per si o n per no");
        string inputUtente = Console.ReadLine();

        if (inputUtente == "s")
        {
            inputCorretto = true;
            inputBool = true;
        }
        else if (inputUtente == "n")
        {
            inputCorretto = true;
            inputBool = false;
        }
    }

    return inputBool;

}

string[] domande = new string[]
{
    "La Terra è piatta",
    "La Terra è il terzo pianeta del sistema solare",
    "La Terra è più grande di Giove",
    "La Terra è più grande di Marte",
    "La Terra è più vicina al Sole di Venere",
};

bool[] risposteGiuste = new bool[]
{
    false,
    true,
    false,
    true,
    false,
};

bool[] risposteUtente = new bool[domande.Length];

for (int i = 0; i < domande.Length; i++)
{
    string domanda = domande[i];
    Console.WriteLine(domanda);

    risposteUtente[i] = InputUtente();

    Console.WriteLine();
}

int numeroRisposteCorrette = 0;
int numeroRisposteSbagliate = 0;
for (int i = 0; i < domande.Length; i++)
{
    if (risposteGiuste[i] == risposteUtente[i])
    {
        numeroRisposteCorrette++;
    }
    else
    {
        numeroRisposteSbagliate++;
    }
}

Console.WriteLine($"Hai risposto correttamente a {numeroRisposteCorrette} domande, ne hai sbagliate {numeroRisposteSbagliate}");