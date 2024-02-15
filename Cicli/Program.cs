
// For loop
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


// Loop si possono usare per navigare un array
string[] menu = new string[]
{
    "Insalata triste",
    "Pasta al ragù",
    "Pasta al pesto",
    "Pizza margherita",
    "Tiramisù",
};

for (int i = 0; i < menu.Length; i++)
{
    string voceDiMenu = menu[i];
    Console.WriteLine(voceDiMenu);
}

// foreach loop
foreach (string voceDiMenu in menu)
{
    Console.WriteLine(voceDiMenu);
}

// ES 
// Trovare il massimo di un array di numeri
int[] numeri = new int[] { 1, 5, 3, 7, 2, 9, 4, 6, 8 };
int massimo = 0;
foreach (int numero in numeri)
{
    if (numero > massimo)
    {
        massimo = numero;
    }
}
Console.WriteLine($"Il massimo è {massimo}");

// ES
// Calcolare la media di un array di numeri
int[] numeri2 = new int[] { 1, 5, 3, 7, 2, 9, 4, 6, 8 };
int somma = 0;
foreach (int numero in numeri2)
{
    somma = somma + numero;
}
double media = (double)somma / numeri2.Length;
Console.WriteLine($"La media è {media}");

// soluzione alternativa
int somma2 = numeri2.Sum();

// ES
// concatenare un array di stringhe
string[] nomi = new string[] { "Mario", "Luigi", "Peach", "Toad", "Yoshi" };
string concatenati = "";
foreach (string nome in nomi)
{
    concatenati = concatenati + nome + " ";
}
Console.WriteLine(concatenati);

// Loop while
//while (true)
//{
//    Console.WriteLine("Ciao");
//}

// loop while possono essere utili per leggere input da tastiera
// in generale, è meglio usare un loop while quando non si sa a priori quante volte si deve eseguire il loop

// ES
// validazione input

//bool inputValido = false;
//int inputNumerico = 0;
//while (!inputValido)
//{
//    Console.WriteLine("Inserisci un numero");

//    string inputUtente = Console.ReadLine();

//    // il parametro è inizializzato fuori dal loop per poterlo usare fuori dal loop
//    // altrimenti non sarebbe disponibile fuori dal loop
//    inputValido = int.TryParse(inputUtente, out inputNumerico);

//    if (!inputValido)
//    {
//        Console.WriteLine("Inserisci un numero valido");
//    }
//}

//Console.WriteLine($"Hai inserito il numero {inputNumerico}");

// Do while loop
// come il while, ma esegue il loop almeno una volta

do
{
    Console.WriteLine("Ciao dal do while");
}
while (false);


// ES
// cliclo for con più array
string[] nomi3 = new string[] { "Mario", "Luigi", "Peach", "Toad", "Yoshi" };
int[] eta = new int[] { 30, 35, 28, 32, 25 };

for (int i = 0; i < nomi3.Length; i++)
{
    string nome = nomi3[i];
    int anni = eta[i];
    Console.WriteLine($"{nome} ha {anni} anni");
}

// ES
// cicli for nidificati
int numeroRighe = 5;
int numeroColonne = 7;
for (int i = 0; i < numeroRighe; i++)
{
    for (int j = 0; j < numeroColonne; j++)
    {
        Console.Write($"x:{j} y:{i}, ");
    }

    Console.WriteLine();
}
