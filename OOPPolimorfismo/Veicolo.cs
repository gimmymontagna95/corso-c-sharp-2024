namespace OOPPolimorfismo;
internal abstract class Veicolo
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Modello { get; set; }

    public abstract void Ripara();
    public abstract bool ControllaStatoRiparazione();
}
