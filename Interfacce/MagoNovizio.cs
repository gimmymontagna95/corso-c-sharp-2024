namespace Interfacce;

// MagoNovizio implementa l'interfaccia IMago

// una classe può estendere una sola classe ma può implementare più interfacce
internal class MagoNovizio : IMago, ILancioMagieDelFuoco
{
    public string Nome { get; set; }

    public void LanciaMagia()
    {
        Console.WriteLine("Lancio una magia!");
    }

    public void LancioMagiaDelFuoco()
    {
        Console.WriteLine("Lancio una magia del fuoco!");
    }
}
