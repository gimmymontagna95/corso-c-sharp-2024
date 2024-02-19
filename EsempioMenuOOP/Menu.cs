namespace EsempioMenuOOP;
internal class Menu
{
    private readonly MenuItem[] _vociMenu = new MenuItem[]
    {
        new MenuItem("Insalata triste", "Insalata con pomodoro e cetrioli", 5.0, true),
        new MenuItem("Pasta al pomodoro", "Pasta con pomodoro", 7.0, true, new Ingrediente[]
        {
            new Ingrediente("pomodoro", 1),
            new Ingrediente("pasta", 200)
        }),
        new MenuItem("Pasta al ragù", "Pasta con ragù", 8.0, false, new Ingrediente[]
        {
            new Ingrediente("pasta", 1),
            new Ingrediente("carne", 20),
        }) ,
        new MenuItem("Pasta al pesto", "Pasta con pesto", 8.0, true, new Ingrediente[]
        {
            new Ingrediente("pasta", 1),
            new Ingrediente("pinoli", 100)
        }),
        new MenuItem("Pizza margherita", "Pizza con pomodoro e mozzarella", 6.0, true),
        new MenuItem("Pizza marinara", "Pizza con pomodoro e aglio", 5.0, true),
        new MenuItem("Pizza quattro stagioni", "Pizza con pomodoro, mozzarella, prosciutto, funghi, carciofi", 9.0, false),
        new MenuItem("Tiramiù", "Dolce al cucchiaio", 4.0, true),
        new MenuItem("Panna cotta", "Dolce al cucchiaio", 4.0, true),
        new MenuItem("Gelato al cioccolato", "Gelato al cioccolato", 3.0, true),
        new MenuItem("Gelato alla vaniglia", "Gelato alla vaniglia", 3.0, true),
        new MenuItem("Acqua", "Bottiglia d'acqua", 1.0, true),
        new MenuItem("Birra", "Bottiglia di birra", 3.0, true),
        new MenuItem("Caffè", "Caffè", 1.0, true)
    };

    public bool CheckHasItem(string item)
    {
        string[] menuFiltrato = Filter(item);

        return menuFiltrato.Length > 0;
    }

    public string[] Filter(string filter)
    {
        string sceltaMinuscola = filter.ToLower();
        MenuItem[] menuFiltrato = Array.FindAll(_vociMenu, (voceDelMenu) =>
        {
            string voceDelMenuMinuscola = voceDelMenu.Name.ToLower();
            bool matchConIlNome = voceDelMenuMinuscola.Contains(sceltaMinuscola);

            string descrizioneDelMenuMinuscola = voceDelMenu.Description.ToLower();
            bool matchConLaDescrizione = descrizioneDelMenuMinuscola.Contains(sceltaMinuscola);

            bool matchVegetariano = false;
            if (sceltaMinuscola == "vegetariano")
            {
                matchVegetariano = voceDelMenu.IsVegetarian;
            }

            bool matchEconomico = false;
            if (sceltaMinuscola == "economico")
            {
                matchEconomico = voceDelMenu.Price < 5;
            }

            bool matchIngrediente = false;
            if (voceDelMenu.Ingredienti != null)
            {
                matchIngrediente = voceDelMenu.Ingredienti.Any(ingrediente =>
                {
                    return ingrediente.Nome.ToLower() == sceltaMinuscola;
                });
            }

            return matchConIlNome || matchConLaDescrizione || matchVegetariano || matchEconomico || matchIngrediente;
        });

        string[] menuFiltratoString = new string[menuFiltrato.Length];
        for (int i = 0; i < menuFiltrato.Length; i++)
        {
            menuFiltratoString[i] = menuFiltrato[i].ToString();
        }

        return menuFiltratoString;
    }

    public override string ToString()
    {
        string str = "Menu:\n";
        foreach (MenuItem item in _vociMenu)
        {
            str = str + $"- {item}\n";
        }
        return str;
    }
}
