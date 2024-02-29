using EsercizioRPG.Maghi;

namespace EsercizioRPG;

internal class Program
{
    static void Main(string[] args)
    {
        Novizio paolo = new Novizio("Paolo", 10);
        MagoMedio mario = new MagoMedio("Mario", 25);
        Arcimago giancarlo = new Arcimago("Giancarlo", 82);

        paolo.Presentati();
        mario.Presentati();
        giancarlo.Presentati();

        Console.WriteLine();
        Console.WriteLine();

        paolo.LanciaMagiaDelVento(giancarlo);

        mario.LanciaMagiaDelVento(giancarlo);
        mario.LanciaMagiaDellaPioggia(mario);

        giancarlo.LanciaMagiaDelVento(paolo);
        giancarlo.LanciaMagiaDellaPioggia(mario);
        giancarlo.LanciaMagiaDelTemporale(paolo);
    }
}
