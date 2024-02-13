Console.WriteLine("Inserisci un numero a piacere");
string inputUtente = Console.ReadLine();

bool numeroValido = int.TryParse(inputUtente, out int numero);
if (numeroValido == false)
{
    Console.WriteLine("Il valore inserito non è un numero");

    return;
}

Console.WriteLine($"Il numero inserito è {numero}");

double valoreOro = 10;
double valoreArgento = 5;
double valoreBronzo = 1;

int numeroOro = (int)Math.Floor(numero / valoreOro);

int restoOro = numero % (int)valoreOro;

int numeroArgento = (int)Math.Floor(restoOro / valoreArgento);

int restoArgento = restoOro % (int)valoreArgento;

int numeroBronzo = (int)Math.Floor(restoArgento / valoreBronzo);


int risultato = numeroOro + numeroArgento + numeroBronzo;

Console.WriteLine($"Il numero minimo di monete è {risultato}\nOro {numeroOro}\nArgento {numeroArgento}\nBronzo {numeroBronzo}");

/*
 * Numeri
 * 
 * +, -, * , /, %
 * Comandi di Math
 * Pow, Sqrt, Abs, Round, Floor, Ceiling
 * 
 * Suggerimento
 * / % Floor
 * */