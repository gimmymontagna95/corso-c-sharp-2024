namespace EsercizioInheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Bicicletta bicicletta = new Bicicletta();
        Automobile automobile = new Automobile();
        MountainBike mountainBike = new MountainBike();

        // non posso istanziare una classe astratta
        //Veicolo veicolo = new Veicolo();
    }
}
