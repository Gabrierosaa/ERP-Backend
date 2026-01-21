namespace ERP_Backend.DTOs.Product;

public class ProductResponseDto
{
    public Guild Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int Price { get; set; }
    public bool Active { get; set; }
}