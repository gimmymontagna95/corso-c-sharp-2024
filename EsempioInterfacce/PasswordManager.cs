namespace EsempioInterfacce;
internal class PasswordManager : IDisplayable, IResettable
{

    public string Title { get; } = "Password Manager";
    public string GetDisplayText()
    {
        return $"Password: {GetPassword()}";
    }

    private string _password;

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

    public void Reset()
    {
        _password = "";
    }
}
