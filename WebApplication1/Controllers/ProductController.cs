using System.Collections.Generic;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    public class ProductController : ApiController
    {
        private readonly ProductRepository productRepository;

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public ProductController()
        {
            productRepository = new ProductRepository();
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAll();
        }

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        [HttpGet]

        public Product Get(int id)
        {
            return productRepository.GetById(id);
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            if (ModelState.IsValid)
                productRepository.Add(prod);
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        [HttpPut]
        public void Put(int id, [FromBody] Product prod)
        {
            prod.ProductId = id;
            if (ModelState.IsValid)
                productRepository.Update(prod);
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        [HttpDelete]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }
}
