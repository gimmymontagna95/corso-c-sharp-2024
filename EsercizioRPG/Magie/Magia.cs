using EsercizioRPG.Maghi;

namespace EsercizioRPG.Magie;
internal abstract class Magia
{

    public abstract string Nome { get; }

    public abstract double BaseDamage { get; }
    public abstract double ManaCost { get; }

    public Novizio Caster { get; }
    public Novizio Target { get; }

    public Magia(Novizio caster, Novizio target)
    {
        Caster = caster;
        Target = target;
    }

    protected virtual double CalculateDamage()
    {
        return BaseDamage + (Caster.Level * 0.1 * BaseDamage);
    }

    protected virtual void Hit()
    {
        var damage = CalculateDamage();

        Target.TakeDamage(damage);
    }

    public virtual void Annuncia()
    {
        Console.WriteLine($"{Caster.Nome} lancia una magia della pioggia contro {Target.Nome}!");

        Hit();

        Console.WriteLine($"{Target.Nome} subisce {CalculateDamage()} danni!");

        if (Target.IsAlive())
        {
            Console.WriteLine($"{Target.Nome} è ancora in vita con {Target.Health} PV!");
        }
        else
        {
            Console.WriteLine($"{Target.Nome} è morto!");
        }

    }
}
