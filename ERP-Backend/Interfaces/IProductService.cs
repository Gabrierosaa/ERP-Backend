using ERP_Backend.DTOs.Product;


namespace ERP_Backend.Interfaces
{
    public interface IProductService
    {

        Task<ProductResponseDto> CreateAsync(ProductCreateDto dto);
        Task<ProductResponseDto> GetByIdAsync(int id);
        Task<ProductResponseDto> UpdateAsync(int id, ProductUpdateDto dto);
        Task<IEnumerable<ProductResponseDto>> GetAllAsync();
        Task<bool> DeleteAsync(int id);
    }
}
