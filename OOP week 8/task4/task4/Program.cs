using System;

class Account
{
    protected string accountNo;
    protected double balance;

    public Account(string accNo, double balance)
    {
        accountNo = accNo;
        this.balance = balance;
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient Balance");
    }

    public virtual void Show()
    {
        Console.WriteLine("Account No: " + accountNo);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingAccount : Account
{
    private double interestRate;

    public SavingAccount(string accNo, double balance, double rate)
        : base(accNo, balance)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        balance += balance * interestRate;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Interest Rate: " + interestRate);
    }
}

class CurrentAccount : Account
{
    private double overdraftLimit;

    public CurrentAccount(string accNo, double balance, double limit)
        : base(accNo, balance)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
            balance -= amount;
        else
            Console.WriteLine("Limit Exceeded");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Overdraft Limit: " + overdraftLimit);
    }
}

class Program
{
    static void Main()
    {
        SavingAccount s = new SavingAccount("SA123", 5000, 0.1);
        s.AddInterest();
        s.Show();

        Console.WriteLine();

        CurrentAccount c = new CurrentAccount("CA456", 3000, 2000);
        c.Withdraw(4000);
        c.Show();
    }
}