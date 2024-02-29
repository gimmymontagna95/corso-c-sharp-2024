namespace EsempioInterfacce;
internal class PasswordManager : IDisplayable
{

    public string Title { get; } = "Password Manager";
    public string GetDisplayText()
    {
        return $"Password: {GetPassword()}";
    }

    private readonly string _password;

    public bool Hidden { get; }

    public PasswordManager(string password, bool hidden)
    {
        _password = password;
        Hidden = hidden;
    }

    public bool CheckPassword(string password)
    {
        return _password == password;
    }

    public string GetPassword()
    {
        // operatore ternario
        //return Hidden ? "Password nascosta" : _password;
        // è equivalente a:
        if (Hidden)
        {
            return "Password nascosta";
        }
        else
        {
            return _password;
        }
    }
}
