using EsercizioRPG.Magie;

namespace EsercizioRPG.Maghi;
internal class Arcimago : MagoMedio
{
    public Arcimago(string name, int level) : base(name, level)
    {
        Health = 100 + level * 1.2;
        Mana = 100 + level * 1.2;
    }

    public override void LanciaMagiaDellaPioggia(Novizio target)
    {
        var magia = new MagiaDellaPioggia(this, target);
        LanciaMagia(magia);
    }

    public override void LanciaMagiaDelVento(Novizio target)
    {
        var magia = new MagiaDelVento(this, target);
        LanciaMagia(magia);
    }

    public virtual void LanciaMagiaDelTemporale(Novizio target)
    {
        var magia = new MagiaDelTemporale(this, target);
        LanciaMagia(magia);
    }

    public override void Presentati()
    {
        Console.WriteLine($"Sono {Nome}, un arcimago di livello {Level} con {Health} PV e {Mana} PM.");
    }
}
