using EsercizioRPG.Maghi;

namespace EsercizioRPG.Magie;
internal class MagiaDelVento : Magia
{
    public override string Nome { get; } = "Magia del Vento";
    public override double BaseDamage { get; } = 10;

    public override double ManaCost { get; } = 20;

    public MagiaDelVento(Novizio caster, Novizio target) : base(caster, target)
    {
    }
}
