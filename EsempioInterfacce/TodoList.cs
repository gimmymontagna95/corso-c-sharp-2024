namespace EsempioInterfacce;
internal class TodoList : IDisplayable
{

    public string Title { get; } = "Lista di cose da fare";

    public string GetDisplayText()
    {
        // stampo una lista numerata di cose da fare
        string result = "";
        for (int i = 0; i < Todos.Length; i++)
        {
            result += $"{i + 1}. {Todos[i]}\n";
        }
        return result;
    }

    public string[] Todos { get; private set; }

    public TodoList()
    {
        Todos = new string[5];
    }

    public void Add(string todo, int idx)
    {
        Todos[idx] = todo;
    }
}
