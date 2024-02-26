namespace EsercizioInheritance;
internal class Bicicletta : Veicolo
{
    public int NumeroMarce { get; set; }
    public bool Elettrica { get; set; }
    public bool Rotelle { get; set; }
    public void Pedala()
    {
        Console.WriteLine("Pedalo");
    }
}
