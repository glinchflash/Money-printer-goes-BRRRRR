namespace AccountManagement;
using ClientManagement;

public class BankAccount
{
    public enum Type {
        CheckingsAccount,
        SavingsAccount,
    }
    
    public Client _client;
    public Type type;
    public int balance = 0;
    
    public BankAccount(int initDeposit, Client client, int typeChoose)
    {
        this.balance += initDeposit;
        this._client = client;
        this.type = TypeSelection(typeChoose);
    }
    
    public int Checkbalance()
    {
        return balance;
    }

    public int Withdraw(int value)
    {
        if (value <= 0)
        {
            throw new Exception("Amount has to be bigger then 0");
        }
        
        if (this.balance - value < 0)
        {
            throw new Exception("Insufficient balance to withdraw this amount!");
        }
        return this.balance -= value;
    }

    public int Deposit(int value)
    {
        if (value <= 0)
        {
            throw new Exception("Amount has to be bigger then 0");
        }
        return this.balance += value;
    }

    public  Type TypeSelection(int Selector)
    {
        if (Selector == 1)
        {
           return type = Type.CheckingsAccount;
        }
        else if (Selector == 2)
        {
            return type = Type.SavingsAccount;
        }
        else
        {
            return type = Type.CheckingsAccount;
        }
    }
}