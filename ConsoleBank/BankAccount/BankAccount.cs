namespace AccountManagement;
using ClientManagement;

public class BankAccount
{
    public Client _client;

    //private Type type;

    public int Balance = 0;
    {
        get { return Balance; }
        set { Balance = value; }
    }
    
    
    public BankAccount(int initDeposit, Client client)
    {
        this.Balance += initDeposit;
        this._client = client;
    }
    /*
    public int CheckBalance
    {
        //
    }

    public int Withdraw
    {
        //
    }

    public int Deposit
    {
        //
    }*/
}