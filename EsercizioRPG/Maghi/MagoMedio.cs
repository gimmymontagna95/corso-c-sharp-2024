using EsercizioRPG.Magie;

namespace EsercizioRPG.Maghi;
internal class MagoMedio : Novizio
{
    public MagoMedio(string name, int level) : base(name, level)
    {
        Health = 100 + level * 0.6;
        Mana = 100 + level * 0.6;
    }

    public virtual void LanciaMagiaDellaPioggia(Novizio target)
    {
        var magia = new MagiaDellaPioggia(this, target);

        LanciaMagia(magia);
    }

    public override void Presentati()
    {
        Console.WriteLine($"Sono {Nome}, un mago medio di livello {Level} con {Health} PV e {Mana} PM.");
    }
}
