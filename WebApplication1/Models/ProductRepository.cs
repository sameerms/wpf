using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace WebApplication1.Models
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository'
    public class ProductRepository
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository'
    {
        private string connectionString;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.ProductRepository()'
        public ProductRepository(){
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.ProductRepository()'
            //DESKTOP-MLCKK3S\sam /W10X64INT0149
            connectionString = @"Persist Security info=False;Initial Catalog=Products;Data Source=W10X64INT0149;Connection Timeout=100000;";
               
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Connection'
        public IDbConnection Connection
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Connection'
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Add(Product)'
        public void Add(Product prod)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Add(Product)'
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Produts(Name,Quantity,Price) VALUES(@Name,@Quantity,@Prce)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.GetAll()'
        public IEnumerable<Product> GetAll()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.GetAll()'
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Produts";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery);
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.GetById(int)'
        public Product GetById(int id)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.GetById(int)'
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Produts Where ProductId=@id";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Delete(int)'
        public void Delete(int id)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Delete(int)'
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE * FROM Produts Where ProductId=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Update(Product)'
        public void Update(Product prod)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ProductRepository.Update(Product)'
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"UPDATE Produts SET Name= @Name,Quantity=@Quantity,Price= @Price Where ProductId=@ProductId";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }
    }      


}
