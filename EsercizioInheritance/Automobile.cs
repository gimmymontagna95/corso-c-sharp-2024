namespace EsercizioInheritance;
internal class Automobile : VeicoloAMotore
{
    public int NumeroPorte { get; set; }
    public int NumeroSedili { get; set; }

    public override void CambiaMarcia()
    {
        if (Alimentazione == "elettrica")
        {
            Console.WriteLine("Non ho le marce");
        }
        else
        {
            Console.WriteLine("Cambio marcia muovendo la leva del cambio");
        }
    }
}
