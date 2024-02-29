namespace Interfacce;

internal class Program
{
    static void Main(string[] args)
    {
        MagoNovizio mago = new MagoNovizio();

        // posso controllare se è implmementata un'interfaccia
        if (mago is IMago)
        {
            Console.WriteLine("Il mago implementa l'interfaccia IMago");
        }

        if (mago is ILancioMagieDelFuoco)
        {
            Console.WriteLine("Il mago implementa l'interfaccia ILancioMagieDelFuoco");
        }

        MagoMedio magoMedio = new MagoMedio();

        if (magoMedio is IMago)
        {
            Console.WriteLine("Il magoMedio implementa l'interfaccia IMago");
        }

        if (magoMedio is ILancioMagieDelFuoco)
        {
            Console.WriteLine("Il magoMedio implementa l'interfaccia ILancioMagieDelFuoco");
        }

        if (magoMedio is ILancioMagieDelGhiaccio)
        {
            Console.WriteLine("Il magoMedio implementa l'interfaccia ILancioMagieDelGhiaccio");
        }

        if (magoMedio is MagoNovizio)
        {
            Console.WriteLine("Il magoMedio è un MagoNovizio");
        }

        LanciaMagiaDelFuoco(mago);
        LanciaMagiaDelFuoco(magoMedio);

        MagoVirtuale magoVirtuale = new MagoVirtuale();

        LanciaMagiaDelFuoco(magoVirtuale);
    }

    // posso usare un'interfaccia come tipo di parametro
    public static void LanciaMagiaDelFuoco(ILancioMagieDelFuoco mago)
    {
        mago.LancioMagiaDelFuoco();
    }
}
