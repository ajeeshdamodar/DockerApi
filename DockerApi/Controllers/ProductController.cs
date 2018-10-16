using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DockerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ApiContext dbContext;

        public ProductController(ApiContext dbContext)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<ApiContext>();
            //var  context = new ApiContext(optionsBuilder.Options);

            this.dbContext = dbContext;

        }

        // GET api/product
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var products = dbContext.Products.ToList();
            return products;
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/product
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/product/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
