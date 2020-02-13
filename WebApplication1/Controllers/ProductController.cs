using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController'
    public class ProductController : ApiController
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController'
    {
        private readonly ProductRepository productRepository;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.ProductController()'
        public ProductController()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.ProductController()'
        {
            productRepository = new ProductRepository();
        }

        [HttpGet]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Get()'
        public IEnumerable<Product> Get()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Get()'
        {
            return productRepository.GetAll();
        }

        [HttpGet]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Get(int)'
        public Product Get(int id)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Get(int)'
        {
            return productRepository.GetById(id);
        }

        [HttpPost]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Post(Product)'
        public void Post([FromBody] Product prod)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Post(Product)'
        {
            if (ModelState.IsValid)
                productRepository.Add(prod);
        }
        [HttpPut]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Put(int, Product)'
        public void Put(int id, [FromBody] Product prod)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Put(int, Product)'
        {
            prod.ProductId = id;
            if (ModelState.IsValid)
                productRepository.Update(prod);
        }
        [HttpDelete]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Delete(int)'
        public void Delete(int id)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductController.Delete(int)'
        {
            productRepository.Delete(id);
        }
    }
}
