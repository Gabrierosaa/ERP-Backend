using ERP_Backend.DTOs;
using ERP_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Backend.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET api/customers/{id}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerResponseDto>> GetById(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        // POST api/customers
        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerResponseDto>> Post(
            [FromBody] CustomerCreateDto dto)
        {
            var createdCustomer = await _customerService.CreateAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = createdCustomer.Id },
                createdCustomer
            );
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, [FromBody] CustomerUpdateDto dto)
        {
            if (dto == null)
                return BadRequest("Dados inválidos.");

            try
            {
                var updatedCustomer = await _customerService.UpdateById(id, dto);

                if (updatedCustomer == null)
                    return NotFound("Cliente não encontrado.");

                return Ok(updatedCustomer);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}

