namespace ERP_Backend.Entities.Enterprise
{
    public class Enterprise
    {
        public int Id { get; set; }
        public string SocialReason { get; set; }
        public string TradeName { get; set; }
        public int Cnpj { get; set; } 
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; }
    }
}
