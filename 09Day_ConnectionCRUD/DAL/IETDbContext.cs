using _09Day_ConnectionCRUD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Day_ConnectionCRUD.DAL
{
    internal class IETDbContext
    {

        String ConnectionString = "Data Source=(LocalDB)\\MSSQLlocalDB;Initial Catalog=aakanksha;Integrated Security=True";

        public List<Product> getAllProducts()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Product", connection);

            connection.Open();


            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> allProductRecords = new List<Product>();

            while (reader.Read())
            {
                allProductRecords.Add(new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    ProductPrice = Convert.ToInt32(reader["ProductPrice"])
                });
            }
            connection.Close();

            return allProductRecords;
        }

        public int InsertProductRecord(Product productToBeInserted)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            string insertProduct = $"Insert into Product(ProductName,ProductPrice) values('{productToBeInserted.ProductName}','{productToBeInserted.ProductPrice}') ";

            SqlCommand cmd = new SqlCommand(insertProduct, con);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public int UpdateProductRecord(int productId, Product productToBeUpdated)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            string updateQuery = $"UPDATE Product SET ProductName= '{productToBeUpdated.ProductName}', ProductPrice = '{productToBeUpdated.ProductPrice}' WHERE ProductId = {productId} ";

            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;

        }

        public int DeleteProduct(int id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            string deleteQuery = $"Delete from product where ProductId={id}";
            SqlCommand cmd = new SqlCommand(deleteQuery, connection);
            connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;

        }
    }
}
