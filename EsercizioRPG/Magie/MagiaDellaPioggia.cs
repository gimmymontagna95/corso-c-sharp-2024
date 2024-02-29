using EsercizioRPG.Maghi;

namespace EsercizioRPG.Magie;
internal class MagiaDellaPioggia : Magia
{
    public override string Nome { get; } = "Magia della Pioggia";
    public override double BaseDamage { get; } = 10;

    public override double ManaCost { get; } = 20;

    public MagiaDellaPioggia(Novizio caster, Novizio target) : base(caster, target)
    {
    }
}
