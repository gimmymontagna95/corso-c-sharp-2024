namespace Interfacce;
internal class MagoMedio : MagoNovizio, ILancioMagieDelGhiaccio
{
    public void LancioMagiaDelGhiaccio()
    {
        Console.WriteLine("Lancio magia del ghiaccio");
    }
}
