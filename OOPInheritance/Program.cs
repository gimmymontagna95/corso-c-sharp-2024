namespace OOPInheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Cane mioCane = new Cane();
        mioCane.Nome = "Fuffi";
        mioCane.Domestico = true;
        mioCane.NumeroZampe = 4;
        mioCane.Razza = "Pastore tedesco";
        mioCane.Proprietario = "Mario Rossi";
        Console.WriteLine(mioCane.EseguiVerso());

        Serpente mioSerpente = new Serpente();
        mioSerpente.Nome = "Max";
        mioSerpente.Domestico = false;
        mioSerpente.Lunghezza = 2.5;
        mioSerpente.Velenoso = true;
        Console.WriteLine(mioSerpente.EseguiVerso());
    }
}
