using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAll();
        }

        [HttpGet]
        public Product Get(int id)
        {
            return productRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            if (ModelState.IsValid)
                productRepository.Add(prod);
        }
        [HttpPut]
        public void Put(int id, [FromBody] Product prod)
        {
            prod.ProductId = id;
            if (ModelState.IsValid)
                productRepository.Update(prod);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }
}
