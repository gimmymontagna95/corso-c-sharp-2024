namespace EsercizioContoBancario;
internal class Account
{
    public string Name { get; private set; }
    public double Balance { get; private set; }

    public Account(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Console.WriteLine($"Deposito di {amount} euro");
        Balance = Balance + amount;
    }

    public bool Withdraw(double amount)
    {
        Console.WriteLine($"Prelievo di {amount} euro");
        if (Balance < amount)
        {
            return false;
        }

        Balance = Balance - amount;

        return true;
    }

    public override string ToString()
    {
        return $"{Name} - {Balance}";
    }
}
