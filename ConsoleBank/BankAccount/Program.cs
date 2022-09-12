//importing (using) the classes we made
using AccountManagement;
using ClientManagement;
//variables
string? name = "";
string? initialBalance="";
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
    Console.WriteLine(client.name);
    // asking for initial balance/deposit and defining it in the bankaccount
    Console.WriteLine("And how much would you like to start with as your initial balance? (first deposit)");
    if (string.IsNullOrEmpty(initialBalance))
    {
        initialBalance = Console.ReadLine();
        
    }

    if (initialBalance is not null && initialBalance is string)
    {
        Console.WriteLine(int.Parse(initialBalance));
        //creating new account
        BankAccount bankAccount = new BankAccount(int.Parse(initialBalance), client);
        Console.WriteLine(bankAccount.Balance + " is your new balance and is created for " +client.name);
    }
}






