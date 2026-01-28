namespace ERP_Backend.DTOs.Product;

public class ProductCreateDto 
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Code { get; set; }
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
}