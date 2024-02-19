namespace EsempioMenuOOP;
internal class Dispensa
{
    public Ingrediente[] IngredientiDisponibili { get; private set; } = new Ingrediente[]
    {
        new Ingrediente("pomodoro", 1000),
        new Ingrediente("pasta", 100),
        new Ingrediente("carne", 1000),
        new Ingrediente("pinoli", 1000),
        new Ingrediente("mozzarella", 1000),
        new Ingrediente("prosciutto", 1000),
        new Ingrediente("funghi", 1000),
        new Ingrediente("carciofi", 1000),
        new Ingrediente("acqua", 1000),
        new Ingrediente("birra", 1000),
        new Ingrediente("caffè", 1000),
    };


    public void Carico(string nomeIngrediente, double quantità)
    {
        Ingrediente ingrediente = FindIngrediente(nomeIngrediente);

        ingrediente.Aggiungi(quantità);
    }

    public void Scarico(string nomeIngrediente, double quantità)
    {
        Ingrediente ingrediente = FindIngrediente(nomeIngrediente);

        ingrediente.Rimuovi(quantità);
    }

    public Ingrediente FindIngrediente(string nomeIngrediente)
    {
        return Array.Find(IngredientiDisponibili, (ingrediente) => ingrediente.Nome == nomeIngrediente);
    }

    public bool CheckHasIngredienti(Ingrediente[] ingredienti)
    {
        bool hasIngredienti = true;
        foreach (Ingrediente ingrediente in ingredienti)
        {
            Ingrediente ingredienteInDispensa = FindIngrediente(ingrediente.Nome);
            if (ingredienteInDispensa.Quantita < ingrediente.Quantita)
            {
                hasIngredienti = false;
            }
        }

        return hasIngredienti;
    }

    public bool CheckHasIngredienti(MenuItem menuItem)
    {
        return CheckHasIngredienti(menuItem.Ingredienti);
    }
}
