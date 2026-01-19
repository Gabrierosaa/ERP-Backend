namespace ERP_Backend.Entities.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } // Email should be unique
        public string PasswordHash { get; set; }
        public bool Active { get; set; } = true; 
        public DateTime CreatedAt { get; set; }

    }
}
