namespace ShopProduct.Models;

public class Product {
    public int Id { get; set;}
    public string? Name { get; set;}
    public string? Description { get; set;}

    public string? Color { get; set;}
    public string? Size { get; set;}
    public int Quantity {get; set;}
    public int Price { get; set;}
    public List<string>? Images { get; set;}
}

