namespace EsercizioContoBancario;

internal class Program
{
    static void Main(string[] args)
    {
        Account accountMario = new Account("Mario Rossi", 1000);

        Console.WriteLine(accountMario);

        accountMario.Deposit(100);

        Console.WriteLine(accountMario);

        bool resultWithdraw = accountMario.Withdraw(200);

        Console.WriteLine(resultWithdraw);
        Console.WriteLine(accountMario);

        bool withdrawResult2 = accountMario.Withdraw(1000);

        Console.WriteLine(withdrawResult2);
        Console.WriteLine(accountMario);




    }
}
