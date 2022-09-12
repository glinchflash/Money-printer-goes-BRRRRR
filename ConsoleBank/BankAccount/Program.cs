//importing (using) the classes we made
using AccountManagement;
using ClientManagement;
//variables
string? name = "";
string? initialBalance="";
string? typeselection = "";
string? actionSelection = "1";
bool quit = false;
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
    Console.WriteLine("And how much would you like to start with as your initial balance? (first deposit)");
    if (string.IsNullOrEmpty(initialBalance))
    {
        initialBalance = Console.ReadLine();
        
    }

    if (string.IsNullOrEmpty(typeselection))
    {
        Console.WriteLine("What kind of account do you want to open?");
        Console.WriteLine("Select 1 for a checkings account");
        Console.WriteLine("Select 2 for a savings account");
        typeselection = Console.ReadLine();
    }


    if (initialBalance != null && typeselection != null)
    {
        //creating new account
        BankAccount bankAccount = new BankAccount(int.Parse(initialBalance), client, int.Parse(typeselection));
        Console.WriteLine("Your new " + bankAccount.type + " has been opened on following name: ");
        Console.WriteLine(client.name);
        Console.WriteLine("And your current balance is: " + bankAccount.Balance);
    
        if (quit != true)
        { 
            Console.WriteLine("Select what you wanna do:");
            Console.WriteLine("Select 1 for checking your balance");
            Console.WriteLine("Select 2 for withdrawing from your account");
            Console.WriteLine("Select 3 for depositing on your account");
            Console.WriteLine("Select anything else to stop!");
            if (string.IsNullOrEmpty(actionSelection))
            {
                actionSelection = Console.ReadLine();
            }

            if (actionSelection == "1")
            {
                Console.WriteLine(bankAccount.CheckBalance());
            }
            else if (actionSelection == "2")
            {
                Console.WriteLine("How much do you want to withdraw?");
                string? WithdrawAmount = Console.ReadLine();
                if (WithdrawAmount != null)
                {
                    bankAccount.Withdraw(int.Parse(WithdrawAmount));
                    Console.WriteLine("You withdrawed " + WithdrawAmount + " of your account");
                    Console.WriteLine("Current balance: " + bankAccount.CheckBalance());
                }
            }
            else if (actionSelection == "3")
            {
                Console.WriteLine("How much do you wanna deposit?");
                string? DepositAmount = Console.ReadLine();
                if (DepositAmount != null)
                {
                    try
                    {
                        bankAccount.Deposit(int.Parse(DepositAmount));
                        Console.WriteLine("You deposited " + DepositAmount + " to your account");
                        Console.WriteLine("Your current balance is now: " + bankAccount.CheckBalance());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
            else if (actionSelection != "1" && actionSelection != "2" && actionSelection != "3")
            {
                Console.WriteLine("Thank you for your bussiness, Untill the next time!");
                quit = true;
                
            }
           
        }
    }
}







