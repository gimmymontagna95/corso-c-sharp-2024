using EsercizioRPG.Magie;

namespace EsercizioRPG.Maghi;
internal class Novizio
{
    public string Nome { get; }
    public int Level { get; set; }
    public double Health { get; set; }
    public double Mana { get; set; }

    public Novizio(string name, int level)
    {
        Nome = name;
        Level = level;
        Health = 100 + level * 0.2;
        Mana = 100 + level * 0.2;
    }

    public virtual bool IsAlive()
    {
        return Health > 0;
    }

    public virtual void TakeDamage(double damage)
    {
        Health = Math.Max(Health - damage, 0);
    }

    public virtual bool ConsumeMana(double mana)
    {
        if (Mana < mana)
        {
            return false;
        }

        Mana = Math.Max(Mana - mana, 0);

        return true;
    }

    protected virtual void LanciaMagia(Magia magia)
    {
        if (!IsAlive())
        {
            Console.WriteLine($"{Nome} è morto e non può lanciare magie!");
            return;
        }

        if (!ConsumeMana(magia.ManaCost))
        {
            Console.WriteLine($"{Nome} non ha abbastanza mana per lanciare {magia.Nome}!");
            return;
        }

        magia.Annuncia();
    }

    public virtual void LanciaMagiaDelVento(Novizio target)
    {
        var magia = new MagiaDelVento(this, target);

        LanciaMagia(magia);
    }

    public virtual void Presentati()
    {
        Console.WriteLine($"Sono {Nome}, un novizio di livello {Level} con {Health} PV e {Mana} PM.");
    }
}
