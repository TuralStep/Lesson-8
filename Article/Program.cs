namespace Article;


struct Article
{
    public string ProductName { get; set; }
    public string ProductCode { get; set; }
    public double Price { get; set; }

    public Article(string productName, string productCode, double price)
    {
        ProductName = productName;
        ProductCode = productCode;
        Price = price;
    }

    public override string ToString() =>
$@"----------Article----------
Product name : {ProductName}
Product code : {ProductCode}
Price : {Price}
---------------------------";

}


class Program
{
    static void Main(string[] args)
    {

        var a1 = new Article("Coca-Cola", "4984144894", 1.55);
        var a2 = new Article("Fanta", "1723664546", 1.25);
        var a3 = new Article("Pepsi", "9786728342", 1.40);

        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(a3);

    }
}