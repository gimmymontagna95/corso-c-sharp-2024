namespace OOPPolimorfismo;

internal class Program
{
    static void Main(string[] args)
    {
        Automobile automobile = new Automobile();
        automobile.FreniGuasti = true;
        automobile.CambioGuasto = true;
        automobile.MotoreGuasto = false;

        Bicicletta bicicletta = new Bicicletta();
        bicicletta.ManubrioStorto = true;
        bicicletta.GommaBucata = false;

        // con la keyword is posso verificare se un oggetto è di un certo tipo
        // grazie al polimorfismo Automobile e Bicicletta sono Veicolo
        if (automobile is Veicolo)
        {
            Console.WriteLine("Automobile è un veicolo");
        }

        if (bicicletta is Veicolo)
        {
            Console.WriteLine("Bicicletta è un veicolo");
        }


        // con il polimorfismo posso usare un oggetto di tipo derivato come se fosse di tipo base
        Officina officinaDiGianluca = new Officina();
        officinaDiGianluca.RiparaVeicolo(automobile);
        officinaDiGianluca.RiparaVeicolo(bicicletta);
        bool autoRiparata = officinaDiGianluca.ControllaStatoRiparazione(automobile);
        bool biciRiparata = officinaDiGianluca.ControllaStatoRiparazione(bicicletta);

        // possiamo convertire una oggetto figlio in un oggetto padre
        //Veicolo veicolo = (Veicolo)automobile; // metodo 1: cast esplicito -> non sicuro, se conversione fallise il programma da errore
        //Veicolo veicolo1 = automobile as Veicolo; // metodo 2: as -> sicuro, se conversione fallisce il programma non da errore, ma restituisce null
        Veicolo veicolo2 = automobile; // metodo 3: cast implicito -> sicuro tutto automatico


        // possiamo convertire un oggetto padre in un oggetto figlio
        Veicolo automobileComeVeicolo = automobile;
        if (automobileComeVeicolo is Automobile)
        {
            Automobile automobileRiconvertita = (Automobile)automobileComeVeicolo;
            Console.WriteLine("Conversione riuscita, il veicolo è un'automobile");
        }
        else
        {
            Console.WriteLine("Conversione non riuscita, il veicolo non è un'automobile");
        }

        if (automobileComeVeicolo is Bicicletta)
        {
            Bicicletta biciclettaRiconvertita = (Bicicletta)automobileComeVeicolo;
            Console.WriteLine("Conversione riuscita, il veicolo è una bicicletta");
        }
        else
        {
            Console.WriteLine("Conversione non riuscita, il veicolo non è una bicicletta");
        }
    }
}
