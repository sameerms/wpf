using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using WebApplication1.Dal;

namespace WebApplication1.Models
{
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    public class ProductRepository : IProductRepository
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    {
        private string connectionString;
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public ProductRepository(){
            ///<Summary>
            /// Gets the answer
            ///</Summary>
            //DESKTOP-MLCKK3S\sam /W10X64INT0149
            //connectionString = @"Persist Security info=False;User ID=sa;password=123;Initial Catalog=Products;Data Source=DESKTOP-MLCKK3S\sam;Connection Timeout=100000;";
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>

        public void Add(Product prod)

        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO dbo.produts(Name,Quantity,Price) VALUES(@Name,@Quantity,@Price)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public IEnumerable<Product> GetAll()

        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM dbo.produts";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery);
            }
        }

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public Product GetById(int id)

        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM dbo.produts Where ProductId=@id";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public void Delete(int id)

        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE FROM dbo.produts Where ProductId=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public void Update(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE dbo.produts SET Name= @Name,Quantity=@Quantity,Price= @Price Where ProductId=@ProductId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
    }      


}
