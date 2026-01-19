namespace ERP_Backend.Entities.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; } = 0;
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; }

    }
}
