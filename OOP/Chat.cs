namespace OOP;
internal class Chat
{
    public string nomeChat = "";
    public string[] messaggi = new string[10];
    public string[] utenti = new string[10];

    public void InviaMessaggio(string messaggio, int idx)
    {
        messaggi[idx] = messaggio;
    }

    public void StampaMessaggi()
    {
        Console.WriteLine($"Messaggi {nomeChat}:");
        foreach (string messaggio in messaggi)
        {
            Console.WriteLine(messaggio);
        }
        Console.WriteLine();
    }
}
