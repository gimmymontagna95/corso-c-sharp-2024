/** Collezioni di DateTime */
// ARRAY
// insieme ordinato di elementi dello stesso tipo

int[] arrayDiNumeriInteri = new int[4] { 1, 2, 3, 4 };

// l'array è una struttura dati di dimensione fissa, non si può cambiare

// posso accedere a un elemento dell'array tramite l'indice
int secondoElemento = arrayDiNumeriInteri[1]; // 2
int terzoElemento = arrayDiNumeriInteri[2]; // 3

// posso modificare un elemento dell'array tramite l'indice
arrayDiNumeriInteri[1] = 10;
// Console.WriteLine(arrayDiNumeriInteri[1]); // 10

// Clone
int[] arrayClonato = new int[4];
arrayDiNumeriInteri.CopyTo(arrayClonato, 0);

// utile se voglio modificare un array senza modificare l'originale
// ES
int[] arrayOriginale = new int[4] { 3, 5, 1, 33 };
int[] arrayModificato = new int[4];
arrayOriginale.CopyTo(arrayModificato, 0);
arrayModificato[0] = 100;

Console.WriteLine($"array modificato: {arrayModificato[0]}, array originale {arrayOriginale[0]}");

// Comandi possibili con gli array

// Fill - utile per inizializzare un array con un valore
int[] arrayDaRiempire = new int[100];
Array.Fill(arrayDaRiempire, 50); // riempie tutto l'array con il valore 50, tutti i 100 elementi

// Clear - utile per azzerare un array
int[] arraDaAzzerare = new int[100];
Array.Clear(arraDaAzzerare); // azzera tutti i 100 elementi 
Array.Clear(arraDaAzzerare, 20, 50); // azzera gli elementi tra l'indice 20 e l'indice 70

// Sort - utile per ordinare un array
int[] arrayDaOrdinare = new int[4] { 3, 5, 1, 33 };
Array.Sort(arrayDaOrdinare); // ordina l'array in modo crescente -> 1, 3, 5, 33

// Reverse - utile per invertire l'ordine degli elementi di un array
int[] arrayDaInvertire = new int[4] { 3, 5, 1, 33 };
Array.Reverse(arrayDaInvertire); // inverte l'ordine degli elementi -> 33, 1, 5, 3

// Sort decrescente
int[] arrayDaOrdinareDecrescente = new int[4] { 3, 5, 1, 33 };
Array.Sort(arrayDaOrdinareDecrescente);
Array.Reverse(arrayDaOrdinareDecrescente); // ordina l'array in modo decrescente -> 33, 5, 3, 1

// IndexOf - utile per trovare l'indice di un elemento
int[] ints = new int[6] { 3, 5, 1, 33, 3, 5 };
int indicePrimaOccorrenzaDi5 = Array.IndexOf(ints, 5); // 1
Array.IndexOf(ints, 203); // -1
int primoValoreDiInts = ints[indicePrimaOccorrenzaDi5]; // 5


// Find
int[] arraySuCuiCercare = new int[9] { 3, 5, 1, 33, 2, 78, 90, 3, 5 };
int valoreCercato = Array.Find(arraySuCuiCercare, (x) =>
{
    return x > 30;
});
int indiceValoreCercato = Array.IndexOf(arraySuCuiCercare, valoreCercato);

Console.WriteLine($"Il valore cercato è {valoreCercato} e si trova all'indice {indiceValoreCercato}");

// Find con stringhe
string[] arrayDiStringhe = new string[4] { "mela", "pera", "banana", "arancia" };
string stringaCercata = Array.Find(arrayDiStringhe, (x) =>
{
    return x.Length > 5;
});
// restituisce la prima stringa che ha lunghezza maggiore di 5, ovvero "banana"

// Contains -> dice se un elemento è presente nell'array
int[] arrayDaCercare = new int[4] { 3, 5, 1, 33 };
arrayDaCercare.Contains(5); // true

// NOTA
// Le stringhe possono essere gestite come array di caratteri e quindi possono essere usate con tutti i metodi degli array
string stringaDaConvertire = "ciao";
char[] arrayDiCaratteri = stringaDaConvertire.ToArray();