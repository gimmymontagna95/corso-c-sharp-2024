namespace EsempioMenuOOP;
internal class Ingrediente
{
    public string Nome { get; private set; }
    public double Quantita { get; private set; }
    public Ingrediente(string nome, double quantita)
    {
        Nome = nome;
        Quantita = quantita;
    }

    public override string ToString()
    {
        return $"{Nome} - {Quantita}";
    }
}
