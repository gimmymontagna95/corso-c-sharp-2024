namespace OOPInheritance;

// Cane eredita da Animale, è una sua sottoclasse
// Cane eredita Nome e Domestico da Animale
internal class Cane : Animale
{

    // possiamo definire delle proprietà specifiche per la classe Cane
    // che non sono comuni a tutte le istanze di Animale
    public int NumeroZampe { get; set; } = 4;
    public string Razza { get; set; }
    public string ColorePelo { get; set; }

    // possiamo sovrascrivere il metodo EseguiVerso
    public override string EseguiVerso()
    {

        // il cane abbaia, sovrascriviamo il metodo
        // l'implementazione del metodo è slegata da quella della classe base
        return "Bau bau!";
    }
}
