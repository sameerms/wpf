using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace WebApplication1.Models
{
    public class ProductRepository
    {
        private string connectionString;
        public ProductRepository(){
            //DESKTOP-MLCKK3S\sam /W10X64INT0149
            connectionString = @"Persist Security info=False;User ID=sa;password=123;Initial Catalog=Products;Data Source=DESKTOP-MLCKK3S\sam;Connection Timeout=100000;";
            }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void Add(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO Produts(Name,Quantity,Price) VALUES(@Name,@Quantity,@Prce)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Produts";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery);
            }
        }

        public Product GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM Produts Where ProductId=@id";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"DELETE * FROM Produts Where ProductId=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }
        public void Update(Product prod)
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
