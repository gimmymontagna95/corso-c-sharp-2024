namespace OOPPolimorfismo;
internal class Automobile : Veicolo
{
    public bool MotoreGuasto { get; set; }
    public bool CambioGuasto { get; set; }
    public bool FreniGuasti { get; set; }

    public string Targa { get; set; }

    public override void Ripara()
    {
        MotoreGuasto = false;
        CambioGuasto = false;
        FreniGuasti = false;
    }

    public override bool ControllaStatoRiparazione()
    {
        bool statoRiparazione = !MotoreGuasto && !CambioGuasto && !FreniGuasti;
        return statoRiparazione;
    }
}
