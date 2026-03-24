class Product
{
    public string Name { get; set; } = "";
    public double Price { get; set; }

    private static int _totalProductsCount = 0;
    private static double _totalProductsPrice = 0.0;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;

        _totalProductsCount++;
        _totalProductsPrice += price;
    }

    public static void PrintWarehouseSummary()
    {
        Console.WriteLine($"Celkem produktu: {_totalProductsCount}; Celkem cena: {_totalProductsPrice}");
    }
}
