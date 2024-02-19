namespace EsempioMenuOOP;
internal class MenuItem
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public bool IsVegetarian { get; private set; }
    public Ingrediente[] Ingredienti { get; private set; }

    public MenuItem(string name, string description, double price, bool isVegetarian, Ingrediente[] ingredienti = null)
    {
        Name = name;
        Description = description;
        Price = price;
        IsVegetarian = isVegetarian;
        Ingredienti = ingredienti;
    }

    // è un meccanismo standard per otternere una rappresentazione testuale di un oggetto
    // devo aggiungere la parola override
    // ToString è utilizzato da Console.WriteLine in automatico
    public override string ToString()
    {
        string str = $"{Name} - {Description} - {Price} euro";

        if (IsVegetarian)
        {
            str = str + " (vegetariano)";
        }

        return str;
    }
}
