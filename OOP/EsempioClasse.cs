namespace OOP;
internal class EsempioClasse
{
    // Fields (campi)

    public int campo1;

    // Properties (proprietà) (nello specifico questa è una auto-property)
    public int Property1 { get; set; }

    // Metodo
    // string è il tipo di 'ritorno'
    // Metodo1 è il nome del metodo
    // int input1 è il parametro del metodo (possono esserci 0 o più parametri)
    public string Metodo1(int input1)
    {
        // il return del metodo definisce il risultato del lavoro svolto dal metodo

        // tutti i metodi che hanno tipo di ritorno diverso da void devono avere un'istruzione di return 
        // che restituisce un valore dello stesso tipo del tipo di ritorno del metodo
        return "Ciao";
    }

    // ES il risultato del metodo è la somma di a e b

    //  nello specifico, questo metodo è una funzione pura, cioè non modifica lo stato dell'oggetto 
    // e il risultato dipende escusivamente dai parametri passati
    public int Somma(int a, int b)
    {
        return a + b;
    }

    public void PrintSomma(int a, int b)
    {
        Console.WriteLine(Somma(a, b));
    }

    // Costruttore di default (se non specificato, il compilatore ne crea uno di default)
    public EsempioClasse()
    {
        // inizializzazione dell'oggetto
    }

    // Costruttore con parametri
    // possono esserci più costruttori nella stessa classe, purché abbiano parametri diversi
    public EsempioClasse(int campo1, int property1)
    {
        // in caso di omonimia tra campo e proprietà, si può usare this per riferirsi al campo della classe
        this.campo1 = campo1;
        Property1 = property1;
    }

    public EsempioClasse(int property1)
    {

    }
}
