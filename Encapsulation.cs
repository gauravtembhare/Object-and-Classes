
using System;

class Account
{
    // Private field: data hiding
    private int accountBalance = 1000;

    // Step 1: Setter method to update balance with validation
    public void SetBalance(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("You cannot pass negative value.");
        }
        else
        {
            accountBalance = amount;
        }
    }

    // Getter method to display balance
    public void GetBalance()
    {
        Console.WriteLine("Your account balance is " + accountBalance);
    }

    // C# property with getter and setter
    public int Balance
    {
        get
        {
            return accountBalance;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("You cannot pass negative value.");
            }
            else
            {
                accountBalance = value;
            }
        }
    }

    // Read-only property example
    public int ReadOnlyBalance
    {
        get { return accountBalance; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account myAccount = new Account();

        Console.WriteLine("=== Getter and Setter Methods ===");

        myAccount.SetBalance(10000);
        myAccount.GetBalance();

        // Try setting a negative balance
        myAccount.SetBalance(-100);
        myAccount.GetBalance();

        Console.WriteLine();

        Console.WriteLine("=== C# Properties ===");

        myAccount.Balance = 10000;
        Console.WriteLine("Your account balance is " + myAccount.Balance);

        // Try setting a negative balance using the property
        myAccount.Balance = -100;
        Console.WriteLine("Your account balance is " + myAccount.Balance);

        Console.WriteLine();

        Console.WriteLine("=== Read-Only Property ===");

        Console.WriteLine("Read-only balance: " + myAccount.ReadOnlyBalance);

        Console.ReadLine();
    }
}
