class BankAccount
{
    public string AccountHolder;
    public double Balance;

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public virtual void CalculateInterest()
    {
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Hesap Sahibi: {AccountHolder}, Bakiye: {Balance} TL");
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance)
    {
    }

    public override void CalculateInterest()
    {
        double interest = Balance * 0.05; // %5 faiz
        Console.WriteLine("Faiz: " + interest + " TL");
    }
}

class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance)
    {
    }

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount("Ahmet", 10000);
        CheckingAccount checking = new CheckingAccount("Mehmet", 5000);

        savings.ShowInfo();
        savings.CalculateInterest();

        Console.WriteLine("-----------------------");

        checking.ShowInfo();
        checking.CalculateInterest();
    }
}
