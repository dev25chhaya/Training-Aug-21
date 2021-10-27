using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    private static int accountNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;

        MakeDeposit(initialBalance, DateTime.Now, "Initital amount");
    }

    private List<Transaction> allTransactions = new List<Transaction>();
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Plese enter positive amount");
        }
        var deposite = new Transaction(amount, date, note);
        allTransactions.Add(deposite);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Plese enter positive amount");
        }
        if (Balance - amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Don't have sufficient balance");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }
}

public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        this.Amount = amount;
        this.Date = date;
        this.Notes = note;
    }
}

public class c2
{
    public static void Main(string[] args)
    {
        BankAccount p1 = new BankAccount("Devanshu", 6000);
        BankAccount p2 = new BankAccount("Milan", 50000);
        p1.MakeWithdrawal(1000, DateTime.Now, "Pizza payment");
        Console.WriteLine(p1.Number+" "+p1.Owner+" "+p1.Balance+" ");
        Console.WriteLine(p2.Number + " " + p2.Owner + " " + p2.Balance + " ");
        Console.ReadLine();
    }
}