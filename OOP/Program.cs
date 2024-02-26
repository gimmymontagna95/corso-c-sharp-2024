using OOP.Classi;

namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {
        // Programmazione imperativa
        // Separazione netta tra dati e operazioni

        // Soluzione: Oggetti -> Object Oriented Programming
        // Dati e operazioni sono raggruppati in un'unica entità

        // Es. oggetto Chat -> oggetto che contiene i messaggi e le operazioni per inviare e ricevere messaggi


        // Per creare un oggetto, dobbiamo definire una classe
        // per creare un oggetto da una classe usiamo la parola chiave new,
        // seguita dal nome della classe e dalle parentesi tonde

        Chat miaChat = new Chat();

        // Chat è il tipo dell'oggetto
        // miaChat è il nome dell'oggetto. è un'istanza della classe Chat

        Chat miaChat1 = new Chat();
        Chat miaChat2 = new Chat();
        // possiamo creare più oggetti della stessa classe

        miaChat.nomeChat = "Chat di gruppo";
        miaChat1.nomeChat = "Chat di famiglia";
        miaChat2.nomeChat = "Chat del corso";

        // ogni oggetto ha i suoi dati
        //Console.WriteLine("miaChat: " + miaChat.nomeChat);
        //Console.WriteLine("miaChat1: " + miaChat1.nomeChat);
        //Console.WriteLine("miaChat2: " + miaChat2.nomeChat);

        // possiamo usare i metodi dell'oggetto
        miaChat.InviaMessaggio("Ciao", 0);
        miaChat.InviaMessaggio("Come va?", 1);

        //miaChat.StampaMessaggi();

        //miaChat1.StampaMessaggi();


        // uno dei principi della OOP è l'incapsulamento,
        // cioè nascondere i dettagli di implementazione e fornire un'interfaccia per interagire con l'oggetto
        // incapsulare dati e logica in un unica entità

        // per utilizzare una classe che sta in un altro namespace, dobbiamo importare il namespace con 'using' all'inizio del file
        Persona persona = new Persona("Luigi", "Rossi", 25, "m");
        Console.WriteLine($"persona.nome ha il valore dato nel costruttore {persona.nome}");

        PersonaConProperties personaConProperties = new PersonaConProperties(
            "Giovanni",
            "Bianchi",
            87,
            "m");

        // possiamo accedere alle proprietà come se fossero fields
        Console.WriteLine($"accedo alle properties come con i fields {personaConProperties.Nome}");


        // con le properties possiamo usare questa sintassi di inizializzazione
        PersonaNoCostruttore personaNoCostruttore = new PersonaNoCostruttore
        {
            Nome = "Mario",
            Cognome = "Verdi",
            Eta = 30,
            Sesso = "m"
        };

        // davati al definizione di classi, fields, properties e medoti
        // sono posti i 'modificiatori di visiibilità'

        // public: accessibile da qualsiasi parte del programma
        // private: accessibile solo dalla classe stessa
        // internal: accessibile solo dallo stesso assembly (progetto)



        Utente utente = new Utente("Mario", "Rossi");
    }
}
