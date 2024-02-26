namespace OOPInheritance;
internal class Serpente : Animale
{
    public bool Velenoso { get; set; }
    public double Lunghezza { get; set; }

    public override string EseguiVerso()
    {
        return "Shhhhhh!";
    }
}
