using System.ComponentModel.DataAnnotations;
using System.Data.Common;

class BankAccount
{
    public string owner;

    public long balance;

    public BankAccount(string ownerName, long ownerBalance)
    {
        owner = ownerName;
        balance = ownerBalance;
    }

    public string Description()
    {
        return $"{owner} has ${balance} in their account";
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount Lachlan = new BankAccount("Lachlan", 999999999999999999);

        BankAccount Person = new BankAccount("Person", 50);

        Console.WriteLine(Lachlan.Description());

        Console.WriteLine(Person.Description());
    }
}
