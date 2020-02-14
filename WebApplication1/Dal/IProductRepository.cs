using System.Collections.Generic;
using System.Data;
using WebApplication1.Models;

namespace WebApplication1.Dal
{      ///<Summary>
       /// Gets the answer
       ///</Summary>
    public interface IProductRepository
    {

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        IDbConnection Connection { get; }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        void Add(Product prod);
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        void Delete(int id);
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        IEnumerable<Product> GetAll();
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        Product GetById(int id);
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        void Update(Product prod);
    }
}