
public class CustomerCreateDto
{
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public bool Active { get; internal set; }
    public DateTime CreatedAt { get; internal set; }
}