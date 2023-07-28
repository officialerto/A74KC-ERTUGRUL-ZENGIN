using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI_STAJ.BusinessLogicLayer;
using WEBAPI_STAJ.Models;

namespace WEBAPI_STAJ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            var products = _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var product = _repository.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("name/{name}")]
        [Authorize]
        public IActionResult GetByName(string name)
        {
            var product = _repository.FindByName(name);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Product product)
        {
            _repository.Insert(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _repository.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var product = _repository.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            _repository.Delete(product);
            return NoContent();
        }
    }
}
