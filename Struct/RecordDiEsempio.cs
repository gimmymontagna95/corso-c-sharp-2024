namespace Struct;

// sono dei reference type come le classi
// 1. sono immutabili di default
// 2. sono comparati in base ai valori dei loro membri
internal record RecordDiEsempio
{
    // init vuol dire che il valore può essere assegnato solo in fase di inizializzazione
    public int X { get; init; }
    public int Y { get; init; }
}
