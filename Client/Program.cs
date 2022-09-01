namespace Client;


struct Client
{

    public Guid ClientCode { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int NumberOfOrdersByClient { get; set; }
    public int TotalAmountOfOrders { get; set; }

    public Client(string fullName, string address, string phone, int numberOfOrdersByClient, int totalAmountOfOrders)
    {
        ClientCode = Guid.NewGuid();
        FullName = fullName;
        Address = address;
        Phone = phone;
        NumberOfOrdersByClient = numberOfOrdersByClient;
        TotalAmountOfOrders = totalAmountOfOrders;
    }

    public override string ToString() =>
$@"---------------Client---------------
Client code : {ClientCode}
Fullname : {FullName}
Address : {Address}
Phone : {Phone}
Number of orders by client : {NumberOfOrdersByClient}
Total amount of orders : {TotalAmountOfOrders}
------------------------------------";

}


class Program
{
    static void Main(string[] args)
    {

        var c1 = new Client("Tural Haji-Nabili", "Somewhere in Baku", "+994 51 123 45 67", 10, 302);
        var c2 = new Client("Nejat Jafarli", "Somewhere in Azerbaijan", "+994 51 987 65 43", 3, 302);
        var c3 = new Client("Elon Musk", "Somewhere in USA", "+994 51 111 22 33", 9, 302);

        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);

    }
}