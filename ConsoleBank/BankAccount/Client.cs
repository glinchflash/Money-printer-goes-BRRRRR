namespace ClientManagement;

public class Client
{
    public int Id;
    public string name;
    public DateTime dateJoined;

    public Client(int id, string name, DateTime date)
    {
        this.Id = id;
        this.name = name;
        this.dateJoined = date;
    }
}