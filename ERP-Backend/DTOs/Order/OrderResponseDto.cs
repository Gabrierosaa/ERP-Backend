public class OrderResponseDto
{
    public int Id { get; set; }
    public float TotalAmount { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}