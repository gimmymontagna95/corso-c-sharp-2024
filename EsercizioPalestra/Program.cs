// Input utente

Console.WriteLine("Inserire durata (in mesi) dell'abbonamento");
var numeroMesi = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire sesso (m o f)");
var sesso = Console.ReadLine();

Console.WriteLine("Inserire fascia oraria (f1 o f2)");
var fasciaOraria = Console.ReadLine();

// Calcolo tariffa

int tariffa;
if (sesso == "m" && fasciaOraria == "f1")
{
    tariffa = 10;
}
else if (sesso == "m" && fasciaOraria == "f2")
{
    tariffa = 15;
}
else if (sesso == "f" && fasciaOraria == "f1")
{
    tariffa = 7;
}
else
{
    tariffa = 11;
}

// Calcolo costo abbonamento

var costoAbbonamento = tariffa * numeroMesi;

// Calcolo sconto
int percentualeSconto = 0;
if (numeroMesi > 6)
{
    percentualeSconto = 25;
}
else if (numeroMesi > 3)
{
    percentualeSconto = 15;
}

var sconto = costoAbbonamento * percentualeSconto / 100;

var costoAbbonamentoScontato = costoAbbonamento - sconto;

// Ouput

Console.WriteLine($"Il costo dell'abbonamento è {costoAbbonamentoScontato}€");

if (percentualeSconto > 0)
{
    Console.WriteLine($"E' stato applicato uno sconto del {percentualeSconto}%, pari a {sconto} euro. Il costo originario era {costoAbbonamento} euro");
}

