namespace MyMvcApp.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Konstruktor med standardvärden
    public ProductModel()
    {
        Name = "Unknown";
        Price = 0;
    }

    // Konstruktor med alla attribut
    public ProductModel(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}
