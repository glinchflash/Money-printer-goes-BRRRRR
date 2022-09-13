//importing (using) the classes we made
using AccountManagement;
using ClientManagement;
//variables
string? name = "";
string? initialbalance="";
string? typeselection = "";
string? actionSelection = "";
//asking for owners name and defining it
Console.WriteLine("Hey, what is the name of the owner of this your new bank account?");
if (string.IsNullOrEmpty(name))
{
    name = Console.ReadLine();
}

if (name is not null)
{
    var currentDate = DateTime.Now;
    Client client = new Client(1, name, currentDate);
    // asking for initial balance/deposit and defining it in the bankaccount
    System.Threading.Thread.Sleep(300);
    Console.WriteLine("And how much would you like to start with as your initial balance? (first deposit)");
    if (string.IsNullOrEmpty(initialbalance))
    {
        initialbalance = Console.ReadLine();
        
    }

    if (string.IsNullOrEmpty(typeselection))
    {
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("What kind of account do you want to open?");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Select 1 for a checkings account");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Select 2 for a savings account");
        
        typeselection = Console.ReadLine();
    }


    if (initialbalance != null && typeselection != null)
    {
        //creating new account
        BankAccount bankAccount = new BankAccount(int.Parse(initialbalance), client, int.Parse(typeselection));
        System.Threading.Thread.Sleep(300);
        Console.WriteLine("Your new " + bankAccount.type + " has been opened on following name: ");
        Console.WriteLine(client.name);
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("And your current balance is: " + bankAccount.balance);
        
        
        while (string.IsNullOrEmpty(actionSelection))
        {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Select what you wanna do:");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Select 1 for checking your balance");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Select 2 for withdrawing from your account");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Select 3 for depositing on your account");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Select anything else to stop!");
                actionSelection = Console.ReadLine();
            

            if (actionSelection == "1")
            { 
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Your current balance is : "+bankAccount.Checkbalance());
                actionSelection = "";
            }
            else if (actionSelection == "2")
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("How much do you want to withdraw?");
                string? WithdrawAmount = Console.ReadLine();
                if (WithdrawAmount != null)
                {
                    bankAccount.Withdraw(int.Parse(WithdrawAmount));
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("You withdrawed " + WithdrawAmount + " of your account");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Current balance: " + bankAccount.Checkbalance());
                }
                actionSelection = "";
            }
            else if (actionSelection == "3")
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("How much do you wanna deposit?");
                string? DepositAmount = Console.ReadLine();
                if (DepositAmount != null)
                {
                    try
                    {
                        bankAccount.Deposit(int.Parse(DepositAmount));
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("You deposited " + DepositAmount + " to your account");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Your current balance is now: " + bankAccount.Checkbalance());
                        actionSelection = "";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
            else
            {
                Console.WriteLine("Thank you for your bussiness, Untill the next time!");
                break;
            }
        }
    }
}








