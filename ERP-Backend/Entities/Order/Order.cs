namespace ERP_Backend.Entities.Order
{
    public class Order
    {
        public int Id { get; set; }
        public float TotalAmount { get; set; }
        public OrderEnum Status { get; set; } = OrderEnum.Created;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
