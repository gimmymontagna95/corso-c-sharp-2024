namespace OOPPolimorfismo;
internal class Officina
{
    public void RiparaVeicolo(Veicolo veicolo)
    {
        veicolo.Ripara();
    }

    public bool ControllaStatoRiparazione(Veicolo veicolo)
    {
        return veicolo.ControllaStatoRiparazione();
    }
}
