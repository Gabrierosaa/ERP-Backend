using ERP_Backend.Interfaces;
using ERP_Backend.DTOs;
using ERP_Backend.Data;
using ERP_Backend.Entities.Customer;
using Microsoft.EntityFrameworkCore;

namespace ERP_Backend.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerResponseDto> CreateAsync(CustomerCreateDto dto)
        {
            // DTO → ENTITY (aqui estava o erro)
            var customer = new Customer
            {
                Name = dto.Name,
                Cpf = dto.Cpf,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                Active = true,
                CreatedAt = DateTime.UtcNow
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            // ENTITY → RESPONSE DTO
            return new CustomerResponseDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Cpf = customer.Cpf,
                PhoneNumber = customer.PhoneNumber,
                Email = customer.Email,
                Active = customer.Active,
                CreatedAt = customer.CreatedAt
            };
        }

        public async Task<CustomerResponseDto?> GetByIdAsync(int id)
        {
            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
                return null;

            return new CustomerResponseDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Cpf = customer.Cpf,
                PhoneNumber = customer.PhoneNumber,
                Email = customer.Email,
                Active = customer.Active,
                CreatedAt = customer.CreatedAt
            };
        }
    }
}
