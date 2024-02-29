namespace EsempioInterfacce;

internal class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();
        todoList.Add("Fare la spesa", 0);
        todoList.Add("Pulire casa", 1);
        todoList.Add("Fare i compiti", 2);
        todoList.Add("Aggiustare macchinetta del caffè", 3);
        todoList.Add("Aggiustare la lampada", 4);

        PasswordManager passwordManager = new PasswordManager("1234", true);

        PrevisioniDelTempo previsioniDelTempo = new PrevisioniDelTempo("Reggio Nell'Emilia");


        // Dashboard

        IDisplayable[] widgets = new IDisplayable[]
        {
            todoList,
            passwordManager,
            previsioniDelTempo
        };


        foreach (var widget in widgets)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(widget.Title);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(widget.GetDisplayText());
            Console.WriteLine("\n\n");
        }
    }
}
