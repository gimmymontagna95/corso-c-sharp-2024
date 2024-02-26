namespace OOP;
internal class Utente
{
    readonly string nome;
    readonly string cognome;
    readonly string email;

    public Utente(string nome, string cognome, string email = "")
    {
        this.nome = nome;
        this.cognome = cognome;
        this.email = email;
    }

    public Utente(string nomeECognome)
    {
        nome = nomeECognome.Split(' ')[0];
        cognome = nomeECognome.Split(' ')[1];
    }

    // non posso avere due costruttori con la stessa firma
    //public Utente(string email) { }
}
