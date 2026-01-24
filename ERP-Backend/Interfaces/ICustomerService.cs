namespace ERP_Backend.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto);
        Task<CustomerResponseDto> GetByIdAsync(int id);
    }
}
