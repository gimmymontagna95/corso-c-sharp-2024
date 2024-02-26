namespace EsercizioInheritance;
internal class Moto : VeicoloAMotore
{
    public double DimensioneRuotaAnteriore { get; set; }
    public double DimensioneRuotaPosteriore { get; set; }

    public override void CambiaMarcia()
    {
        Console.WriteLine("Cambio marcia muovendo il pedale");
    }
}
