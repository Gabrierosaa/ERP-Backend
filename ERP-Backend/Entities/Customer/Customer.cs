namespace ERP_Backend.Entities.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; } // CPF should be unique
        public string PhoneNumber { get; set; }
        public string Email { get; set; } // Email should be unique
        public bool Active { get; set; } = true;
        public DateTime CreatedAt { get; set; }
    }
}
