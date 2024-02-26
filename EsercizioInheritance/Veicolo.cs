namespace EsercizioInheritance;
// una classe abstract è una classe che non si può istanziare
// ma può essere usata come classe base per altre classi
// server a rafforzare dei vincoli di progettazione
internal abstract class Veicolo
{
    public string Nome { get; set; }
    public string Decrizione { get; set; }
    public string Marca { get; set; }
    public string Modello { get; set; }
    public string Colore { get; set; }
}
