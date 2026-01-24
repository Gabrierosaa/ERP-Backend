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
            if (!CpfValido(dto.Cpf))
                throw new ArgumentException("CPF inválido.");
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

        private bool CpfValido(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.Distinct().Count() == 1)
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int dv1 = (soma * 10) % 11;
            if (dv1 == 10) dv1 = 0;

            if (dv1 != (cpf[9] - '0'))
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            int dv2 = (soma * 10) % 11;
            if (dv2 == 10) dv2 = 0;

            return dv2 == (cpf[10] - '0');
        }
    }
}
