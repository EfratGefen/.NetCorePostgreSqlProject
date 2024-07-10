using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.MODELS;

namespace Opticsproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _dbCustomer;
        public CustomerController(ICustomer dbCustomer)
        {
            _dbCustomer = dbCustomer;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto value)
        {
          bool create= await _dbCustomer.CreateCustomer(value);
            if (create)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            bool delete = await _dbCustomer.DeleteCustomer(id);
            if (delete)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<Customer> Get(long id)
        {
            Customer c = await _dbCustomer.GetCustomer(id);

            return c;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CustomerDto c)
        {
            bool put = await _dbCustomer.UpdateCustomer(id,c);
            if (put)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
