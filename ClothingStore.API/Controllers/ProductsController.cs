using Microsoft.AspNetCore.Mvc;
using ClothingStore.API.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClothingStore.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ClothingStore.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                return await _context.Products.AsNoTracking().ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            try
            {
                var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);
                if (product == null)
                {
                    return NotFound($"The product id={id} was not found");
                }
                return product;
            }
            catch (Exception e )
            {
                return BadRequest(e.Message); ;
            }

        }

        // POST: api/Products
        [HttpPost] 
        public ActionResult PostProduct([FromBody]Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges(); 
                return new CreatedAtRouteResult("GetProduct", new { id = product.ProductId }, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message); ;
            }
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult PutProduct(int id, [FromBody]Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    return BadRequest();
                }

                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok($"The product id={id} has been updated successfully ");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
