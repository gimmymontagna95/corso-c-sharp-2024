namespace EsercizioInheritance;
internal abstract class VeicoloAMotore : Veicolo
{
    public string Cilindrata { get; set; }
    public string Alimentazione { get; set; }
    public bool Assicurazione { get; set; }

    public void Accelera()
    {
        Console.WriteLine("Accelero");
    }

    public void Frena()
    {
        Console.WriteLine("Freno");
    }

    public void Accendi()
    {
        Console.WriteLine("Accendo");
    }

    // dentro una classe astratta posso definire un metodo astratto
    // un metodo astratto non ha implementazione
    public abstract void CambiaMarcia();
}
