namespace OOPPolimorfismo;
internal class Bicicletta : Veicolo
{
    public bool GommaBucata { get; set; }
    public bool ManubrioStorto { get; set; }

    public int NumeroDiMarce { get; set; }

    public override void Ripara()
    {
        GommaBucata = false;
        ManubrioStorto = false;
    }

    public override bool ControllaStatoRiparazione()
    {
        bool statoRiparazione = !GommaBucata && !ManubrioStorto;
        return statoRiparazione;
    }
}
