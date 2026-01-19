namespace ERP_Backend.Entities.Supplier
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; } // CNPJ should be unique
        public string PhoneNumber { get; set; }
        public string Email { get; set; } // Email should be unique
        public bool Active { get; set; } = true;
    }
}
