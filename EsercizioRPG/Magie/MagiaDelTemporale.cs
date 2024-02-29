using EsercizioRPG.Maghi;

namespace EsercizioRPG.Magie;
internal class MagiaDelTemporale : Magia
{
    public override string Nome { get; } = "Magia del Temporale";
    public override double BaseDamage { get; } = 10;

    public override double ManaCost { get; } = 20;

    public MagiaDelTemporale(Novizio caster, Novizio target) : base(caster, target)
    {
    }

}
