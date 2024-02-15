namespace EsercizioCalcoloArea;

internal class Program
{
    static void Main(string[] args)
    {
        int costoAlMetroQuadro = 100;

        double latoARettangolo = 15;
        double latoBRettangolo = 18;
        double raggioCerchio = 21.5;


        double areaRettangolo = CalcolaAreaRettangolo(latoARettangolo, latoBRettangolo);
        double areaCerchio = CalcolaAreaCerchio(raggioCerchio);
        double areaTotale = CalcoloAreaTotale(areaRettangolo, areaCerchio);
        double costo = CalcolaCosto(areaTotale, costoAlMetroQuadro);

        Console.WriteLine($"Costo totale {costo}");
    }

    public static double CalcolaAreaRettangolo(double latoA, double latoB)
    {
        return latoA * latoB;
    }

    public static double CalcolaAreaCerchio(double raggio)
    {
        // Math.PI è una costante che rappresenta il valore di π, in alternativa di può usare 3.14
        return Math.PI * Math.Pow(raggio, 2);
    }

    public static double CalcoloAreaTotale(double areaRettangolo, double areaCerchio)
    {
        return areaRettangolo + areaCerchio;
    }

    public static double CalcolaCosto(double area, int costoAlMetroQuadro)
    {
        return area * costoAlMetroQuadro;
    }
}
